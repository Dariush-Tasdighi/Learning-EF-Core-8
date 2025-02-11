//using System;
//using Microsoft.EntityFrameworkCore;

//// **************************************************
//// دستورات ذیل را در درس قبل یاد گرفته‌ایم
//// **************************************************
//var applicationDbContext = new ApplicationDbContext();

//var category =
//	new Category
//	{
//		Name = "My Category 1",
//	};

//applicationDbContext.Categories.Add(entity: category);

//applicationDbContext.SaveChanges();

//applicationDbContext.Dispose();
//// **************************************************

//// **************************************************
////using (var applicationDbContext = new ApplicationDbContext())
////{
////	var category =
////		new Category
////		{
////			Name = "My Category",
////		};

////	applicationDbContext.Categories.Add(entity: category);

////	applicationDbContext.SaveChanges();
////}
//// **************************************************

//// **************************************************
////using var applicationDbContext = new ApplicationDbContext();

////var category =
////	new Category
////	{
////		Name = "My Category",
////	};

////applicationDbContext.Categories.Add(entity: category);

////applicationDbContext.SaveChanges();

////// چندین خط دیگر
//// **************************************************

//// **************************************************
////using var applicationDbContext = new ApplicationDbContext();

////var category =
////	new Category
////	{
////		Name = "My Category",
////	};

////// New in EF Core
////applicationDbContext.Add(entity: category);

////applicationDbContext.SaveChanges();
//// **************************************************

//// **************************************************
////try
////{
////	using var applicationDbContext = new ApplicationDbContext();

////	var category =
////		new Category
////		{
////			Name = "My Category",
////		};

////	applicationDbContext.Add(entity: category);

////	applicationDbContext.SaveChanges();
////}
////catch (Exception ex)
////{
////	Console.WriteLine(value: ex.Message);
////}
//// **************************************************

//// **************************************************
////try
////{
////	using var applicationDbContext = new ApplicationDbContext();

////	var category =
////		new Category
////		{
////			Name = "My Category",
////		};

////	applicationDbContext.Add(entity: category);

////	applicationDbContext.SaveChanges();
////}
////catch (Exception ex)
////{
////	// Log Error (ex)!

////	// از نظر مسائل ظاهری و امنیتی دستور ذیل مناسب نمی‌باشد
////	//Console.WriteLine(value: ex.Message);

////	Console.WriteLine(value: "Unexpected Error!");
////}
//// **************************************************

//public class Category : object
//{
//	public Category() : base()
//	{
//	}

//	public int Id { get; set; }

//	public string? Name { get; set; }
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
