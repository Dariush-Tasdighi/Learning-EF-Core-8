using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

try
{
	using var applicationDbContext = new ApplicationDbContext();

	// **************************************************
	var categories =
		applicationDbContext.Categories.ToList();

	// SQL = TSQL = SELECT * FROM Categories

	if (categories.Count == 0)
	{
		// ایجاد ده طبقه‌بندی
	}
	// **************************************************

	// **************************************************
	// نکته بسیار مهم
	//
	// حواسمان باشد که ذهن‌مان شرطی نشود
	// **************************************************

	// **************************************************
	//var categoryCount =
	//	applicationDbContext.Categories.Count();

	//if (categoryCount == 0)
	//{
	//	// ایجاد ده طبقه‌بندی
	//}
	// **************************************************

	// **************************************************
	//var hasAnyCategory =
	//	applicationDbContext.Categories.Any();

	//if (hasAnyCategory == false)
	//{
	//	// ایجاد ده طبقه‌بندی
	//}
	// **************************************************

	// **************************************************
	// Non-Transactional
	// **************************************************
	//var hasAnyCategory =
	//	applicationDbContext.Categories.Any();

	//if (hasAnyCategory == false)
	//{
	//	for (var index = 1; index <= 9; index++)
	//	{
	//		Category category;

	//		category =
	//			new()
	//			{
	//				Name = $"Category {index}",
	//				IsActive = (index % 2 == 0),
	//			};

	//		applicationDbContext.Add(entity: category);

	//		applicationDbContext.SaveChanges();
	//	}
	//}
	// **************************************************

	// **************************************************
	// Transactional
	// **************************************************
	//var hasAnyCategory =
	//	applicationDbContext.Categories.Any();

	//if (hasAnyCategory == false)
	//{
	//	for (var index = 1; index <= 9; index++)
	//	{
	//		Category category;

	//		category =
	//			new()
	//			{
	//				Name = $"Category {index}",
	//				IsActive = (index % 2 == 0),
	//			};

	//		applicationDbContext.Add(entity: category);
	//	}

	//	applicationDbContext.SaveChanges();
	//}
	// **************************************************

	// **************************************************
	// LINQ
	// **************************************************
	//var categories =
	//	applicationDbContext.Categories.ToList();
	// **********

	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.ToList()
	//	;

	//foreach (var category in categories)
	//{
	//	Console.WriteLine(value: category.ToString());
	//}
	// **********

	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6 && current.IsActive)
	//	.ToList()
	//	;
	// **********

	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6)
	//	.Where(predicate: current => current.IsActive)
	//	.ToList()
	//	;
	// **********

	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6 || current.IsActive)
	//	.ToList()
	//	;
	// **********

	// **********
	//var search = "Category";

	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6)
	//	.Where(predicate: current => current.IsActive)
	//	.Where(predicate: current => current.Name != null &&
	//		current.Name.ToLower().Contains(search.ToLower()))
	//	.ToList()
	//	;
	// **********

	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.OrderBy(keySelector: current => current.IsActive)
	//	.Where(predicate: current => current.Id <= 6)
	//	.ToList()
	//	;

	//foreach (var category in categories)
	//{
	//	Console.WriteLine(value: category.ToString());
	//}
	// **********

	// **********
	// Best Practice
	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6)
	//	.OrderBy(keySelector: current => current.IsActive)
	//	.ToList()
	//	;

	//foreach (var category in categories)
	//{
	//	Console.WriteLine(value: category.ToString());
	//}
	// **********

	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6)
	//	.OrderByDescending(keySelector: current => current.IsActive)
	//	.ToList()
	//	;

	//foreach (var category in categories)
	//{
	//	Console.WriteLine(value: category.ToString());
	//}
	// **********

	// **********
	// دستور ذیل غلط است و درست کار نمی‌کند
	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6)
	//	.OrderBy(keySelector: current => current.IsActive)
	//	.OrderBy(keySelector: current => current.Id)
	//	.ToList()
	//	;

	//foreach (var category in categories)
	//{
	//	Console.WriteLine(value: category.ToString());
	//}
	// **********

	// **********
	// دستور ذیل غلط است و درست کار نمی‌کند
	// **********
	//var categories =
	//	applicationDbContext.Categories
	//	.Where(predicate: current => current.Id <= 6)
	//	.OrderBy(keySelector: current => current.IsActive)
	//	.ThenBy(keySelector: current => current.Id)
	//	.ToList()
	//	;

	//foreach (var category in categories)
	//{
	//	Console.WriteLine(value: category.ToString());
	//}
	// **********

	// **********
	// به طور خلاصه
	//
	// OrderBy
	// ThenBy
	// ThenBy...
	//
	// OrderByDescending
	// ThenBy
	// ThenBy...
	//
	// OrderBy
	// ThenByDescending
	// ThenBy...
	//
	// OrderByDescending
	// ThenByDescending
	// ThenBy...
	// **********
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

	/// <summary>
	/// New
	/// </summary>
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
