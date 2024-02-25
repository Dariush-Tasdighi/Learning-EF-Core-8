using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

try
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

	// **************************************************
	// Update One Record
	// **************************************************
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
		// بعدا خیلی بیشتر توضیح خواهم داد
		foundedCategory.Name = "Category 1";
		// با اجرای دستور فوق، هیچ اتفاقی رخ نمی‌دهد

		foundedCategory.Name = "New Category Name!";

		applicationDbContext.SaveChanges();
	}
	// **************************************************

	// **************************************************
	// Update More Than One Record
	// **************************************************
	//var foundedCategories =
	//	applicationDbContext.Categories
	//	.Where(current => current.IsActive == false)
	//	.ToList()
	//	;

	//foreach (var foundedCategory in foundedCategories)
	//{
	//	foundedCategory.IsActive = true;

	//	//applicationDbContext.SaveChanges();
	//}

	//applicationDbContext.SaveChanges();
	// **************************************************

	// **************************************************
	// دستور هیجان‌انگیز ذیل را قبلا نداشتیم
	// **************************************************
	//applicationDbContext.Categories
	//	.Where(current => current.IsActive == false)
	//	.ExecuteUpdate(setters => setters.SetProperty(property => property.IsActive, true));
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
