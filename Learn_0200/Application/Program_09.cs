using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

try
{
	{
		using var applicationDbContext = new ApplicationDbContext();

		var hasAnyCategory =
			applicationDbContext.Categories.Any();

		if (hasAnyCategory == false)
		{
			for (var index = 1; index <= 9; index++)
			{
				var category =
					new Category
					{
						Name = $"Category {index}",
						IsActive = (index % 2 == 0),
					};

				applicationDbContext.Add(entity: category);

				applicationDbContext.SaveChanges();
			}
		}
	}

	// **************************************************
	// Delete One Record
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundedCategory =
			applicationDbContext.Categories
			.Where(current => current.Id == 1)
			.FirstOrDefault();

		if (foundedCategory is null)
		{
			var errorMessage =
				$"There is not any category with this Id (1)!";

			Console.WriteLine(value: errorMessage);
		}
		else
		{
			var state1 =
				applicationDbContext.Entry(entity: foundedCategory).State;

			//applicationDbContext.Categories.Remove(entity: foundedCategory);

			applicationDbContext.Remove(entity: foundedCategory);

			var state2 =
				applicationDbContext.Entry(entity: foundedCategory).State;

			applicationDbContext.SaveChanges();

			var state3 =
				applicationDbContext.Entry(entity: foundedCategory).State;
		}
	}
	// **************************************************

	// **************************************************
	// Delete More Than One Record
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundedCategories =
			applicationDbContext.Categories
			.Where(current => current.IsActive == false)
			.ToList()
			;

		foreach (var foundedCategory in foundedCategories)
		{
			applicationDbContext.Remove(entity: foundedCategory);

			//applicationDbContext.SaveChanges();
		}

		applicationDbContext.SaveChanges();
	}
	// **************************************************

	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		//applicationDbContext.RemoveRange(category1, category2, ...);
	}
	// **************************************************

	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundedCategories =
			applicationDbContext.Categories
			.Where(current => current.IsActive == false)
			.ToList()
			;

		applicationDbContext.RemoveRange(entities: foundedCategories);

		applicationDbContext.SaveChanges();
	}
	// **************************************************

	// **************************************************
	// روشی که لااقل برای حذف تعداد زیادی رکورد
	// خیلی هوشمندانه‌تر می‌باشد، ولی متاسفانه خطر
	// SQL Injection
	// داشته و نیز باید به جای دستورات
	// LINQ
	// از دستورات
	// SQL = TSQL
	// استفاده نماییم
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var sql =
			"DELETE Categories WHERE IsActive = 0";

		var affectedRows =
			applicationDbContext.Database.ExecuteSqlRaw(sql: sql);

		Console.WriteLine(value: affectedRows);
	}
	// **************************************************

	// **************************************************
	// دستور هیجان‌انگیز ذیل را قبلا نداشتیم
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var affectedRows =
			applicationDbContext.Categories
				.Where(current => current.IsActive == false)
				.ExecuteDelete();

		Console.WriteLine(value: affectedRows);
	}
	// **************************************************

	// **************************************************
	// Update One Record!
	// AsNoTracking()
	// این دستور، سرعت و کارایی را بالا می‌برد
	// ولی تغییرات (ایجاد، ویرایش و حذف) را شناسایی نمی‌کند
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundedCategory =
			applicationDbContext.Categories
			.AsNoTracking()
			.Where(current => current.Id == 1)
			.FirstOrDefault();

		if (foundedCategory is null)
		{
			var errorMessage =
				$"There is not any category with this Id (1)!";

			Console.WriteLine(value: errorMessage);
		}
		else
		{
			var state1 =
				applicationDbContext.Entry(entity: foundedCategory).State;

			applicationDbContext.Remove(entity: foundedCategory);
			//applicationDbContext.Categories.Remove(entity: foundedCategory);

			var state2 =
				applicationDbContext.Entry(entity: foundedCategory).State;

			// کار نمی‌کند
			applicationDbContext.SaveChanges();

			var state3 =
				applicationDbContext.Entry(entity: foundedCategory).State;
		}
	}
	// **************************************************
}
catch (Exception ex)
{
	Console.WriteLine(value: ex.Message);
}
// **************************************************

public class Category : object
{
	public Category() : base()
	{
	}

	public int Id { get; set; }

	public string? Name { get; set; }

	public bool IsActive { get; set; }

	public override string ToString()
	{
		var result =
			$"{nameof(Id)}: {Id} - {nameof(Name)}: {Name} - {nameof(IsActive)}: {IsActive}";

		return result;
	}
}

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext() : base()
	{
		Database.EnsureCreated();
	}

	public DbSet<Category> Categories { get; set; }

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}
}
