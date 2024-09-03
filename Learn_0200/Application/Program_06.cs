//using System;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//try
//{
//	using var applicationDbContext = new ApplicationDbContext();

//	// **************************************************
//	var categories =
//		applicationDbContext.Categories.ToList();

//	// SQL = TSQL = SELECT * FROM Categories

//	if (categories.Count == 0)
//	{
//		// ایجاد نه طبقه‌بندی
//	}
//	// **************************************************

//	// **************************************************
//	// نکته بسیار مهم
//	//
//	// حواسمان باشد که ذهن‌مان شرطی نشود
//	// **************************************************

//	// **************************************************
//	//var categoryCount =
//	//	applicationDbContext.Categories.Count();

//	//// SQL = TSQL = SELECT COUNT(*) FROM Categories

//	//if (categoryCount == 0)
//	//{
//	//	// ایجاد نه طبقه‌بندی
//	//}
//	// **************************************************

//	// **************************************************
//	//var hasAnyCategory =
//	//	applicationDbContext.Categories.Any();

//	//if (hasAnyCategory == false)
//	//{
//	//	// ایجاد نه طبقه‌بندی
//	//}
//	// **************************************************

//	// **************************************************
//	// Non-Transactional
//	// **************************************************
//	//var hasAnyCategory =
//	//	applicationDbContext.Categories.Any();

//	//if (hasAnyCategory == false)
//	//{
//	//	for (var index = 1; index <= 9; index++)
//	//	{
//	//		var category =
//	//			new Category
//	//			{
//	//				Name = $"Category {index}",
//	//				IsActive = (index % 2 == 0),
//	//			};

//	//		applicationDbContext.Add(entity: category);

//	//		applicationDbContext.SaveChanges();
//	//	}
//	//}
//	// **************************************************

//	// **************************************************
//	// Transactional
//	// **************************************************
//	//var hasAnyCategory =
//	//	applicationDbContext.Categories.Any();

//	//if (hasAnyCategory == false)
//	//{
//	//	for (var index = 1; index <= 9; index++)
//	//	{
//	//		var category =
//	//			new Category
//	//			{
//	//				Name = $"Category {index}",
//	//				IsActive = (index % 2 == 0),
//	//			};

//	//		applicationDbContext.Add(entity: category);
//	//	}

//	//	applicationDbContext.SaveChanges();
//	//}
//	// **************************************************
//}
//catch (Exception ex)
//{
//	Console.WriteLine(value: ex.Message);
//}
//// **************************************************

//public class Category : object
//{
//	public Category() : base()
//	{
//	}

//	public int Id { get; set; }

//	public string? Name { get; set; }

//	/// <summary>
//	/// New
//	/// </summary>
//	public bool IsActive { get; set; }

//	public override string ToString()
//	{
//		var result =
//			$"{nameof(Id)}: {Id} - {nameof(Name)}: {Name} - {nameof(IsActive)}: {IsActive}";

//		return result;
//	}
//}

//public class ApplicationDbContext : DbContext
//{
//	public ApplicationDbContext() : base()
//	{
//		Database.EnsureCreated();
//	}

//	public DbSet<Category> Categories { get; set; }

//	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		optionsBuilder
//			.UseSqlServer(connectionString: connectionString)
//			;
//	}
//}
