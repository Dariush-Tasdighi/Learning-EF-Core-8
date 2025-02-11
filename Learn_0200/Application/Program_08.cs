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

	//**************************************************
	// Update One Record
	//**************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundCategory =
			applicationDbContext.Categories
			.Where(current => current.Id == 1)
			.FirstOrDefault();

		if (foundCategory is null)
		{
			var errorMessage =
				$"There is not any category with this Id (1)!";

			Console.WriteLine(value: errorMessage);
		}
		else
		{
			var state1 =
				applicationDbContext.Entry(entity: foundCategory).State;

			// با اجرای دستور ذیل، هیچ اتفاقی رخ نمی‌دهد
			// در این خصوص بعدا خیلی بیشتر توضیح خواهم داد
			foundCategory.Name = "Category 1";

			var state2 =
				applicationDbContext.Entry(entity: foundCategory).State;

			foundCategory.Name = "New Category Name!";

			var state3 =
				applicationDbContext.Entry(entity: foundCategory).State;

			foundCategory.Name = "Category 1";

			var state4 =
				applicationDbContext.Entry(entity: foundCategory).State; // Modified!

			applicationDbContext.SaveChanges();

			var state5 =
				applicationDbContext.Entry(entity: foundCategory).State;
		}
	}
	//**************************************************

	// **************************************************
	// Update More Than One Record
	// روشی که اگر تعداد رکوردها خیلی
	// زیاد باشد، خیلی احمقانه به نظر می‌رسد
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundCategories =
			applicationDbContext.Categories
			.Where(current => current.IsActive == false)
			.ToList()
			;

		foreach (var foundCategory in foundCategories)
		{
			foundCategory.IsActive = true;

			//applicationDbContext.SaveChanges();
		}

		applicationDbContext.SaveChanges();
	}
	// **************************************************

	// **************************************************
	// روشی که لااقل برای ویرایش تعداد زیادی رکورد
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

		var sql = "UPDATE Categories SET IsActive = 1 WHERE IsActive = 0";

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
				.ExecuteUpdate(setters => setters.SetProperty(property => property.IsActive, true));

		Console.WriteLine(value: affectedRows);
	}
	// **************************************************

	// **************************************************
	// Update One Record!
	// AsNoTracking()
	// این دستور، سرعت و کارایی را بالا می‌برد
	// ولی تغییرات (ایجاد، ویرایش ) را شناسایی نمی‌کند
	// **************************************************
	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundCategory =
			applicationDbContext.Categories
			.AsNoTracking()
			.Where(current => current.Id == 1)
			.FirstOrDefault();

		if (foundCategory is null)
		{
			var errorMessage =
				$"There is not any category with this Id (1)!";

			Console.WriteLine(value: errorMessage);
		}
		else
		{
			var state1 =
				applicationDbContext.Entry(entity: foundCategory).State;

			foundCategory.Name = "New Category Name!";

			var state2 =
				applicationDbContext.Entry(entity: foundCategory).State;

			// کار نمی‌کند
			var affectedRows =
				applicationDbContext.SaveChanges();

			var state3 =
				applicationDbContext.Entry(entity: foundCategory).State;
		}
	}
	// **************************************************

	// **************************************************
	// Update One Record
	// بدون این‌که داده را از بانک‌اطلاعاتی به
	// برنامه منتقل کنیم و صرفا آی‌دی آن رکورد را داریم
	// **************************************************
	//{
	//	using var applicationDbContext = new ApplicationDbContext();

	//	var theCategory =
	//		new Category
	//		{
	//			Id = 1,
	//			IsActive = true,
	//			Name = "New Category",
	//		};

	//	var state1 =
	//		applicationDbContext.Entry(entity: theCategory).State;

	//	applicationDbContext.Entry(entity: theCategory).State = EntityState.Modified;

	//	var state2 =
	//		applicationDbContext.Entry(entity: theCategory).State;

	//	var affectedRows =
	//		applicationDbContext.SaveChanges();

	//	var state3 =
	//		applicationDbContext.Entry(entity: theCategory).State;
	//}
	// **************************************************

	// **************************************************
	// Update One Record
	// بدون این‌که داده را از بانک‌اطلاعاتی به
	// برنامه منتقل کنیم و صرفا آی‌دی آن رکورد را داریم
	// **************************************************
	//{
	//	using var applicationDbContext = new ApplicationDbContext();

	//	var theCategory =
	//		new Category
	//		{
	//			Id = 1,
	//			IsActive = true,
	//			Name = "New Category",
	//		};

	//	var state1 =
	//		applicationDbContext.Entry(entity: theCategory).State;

	//	applicationDbContext.Update(entity: theCategory);
	//	//applicationDbContext.Categories.Update(entity: theCategory);

	//	// نکته مهم
	//	// مشابه این دستور
	//	// نداریم Delete متاسفانه دستور

	//	var state2 =
	//		applicationDbContext.Entry(entity: theCategory).State;

	//	var affectedRows =
	//		applicationDbContext.SaveChanges();

	//	var state3 =
	//		applicationDbContext.Entry(entity: theCategory).State;
	//}
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

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder
			.UseSqlServer(connectionString: connectionString)
			;
	}
}
