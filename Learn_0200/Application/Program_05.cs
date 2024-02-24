//using System;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//// **************************************************
//try
//{
//	using var applicationDbContext = new ApplicationDbContext();

//	var category =
//		applicationDbContext.Categories
//		.FirstOrDefault();

//	//if (category == null)
//	if (category is null)
//	{
//		Console.WriteLine
//			(value: "There is not any category!");
//	}
//	else
//	{
//		Console.WriteLine(value: category.ToString());
//	}
//}
//catch (Exception ex)
//{
//	Console.WriteLine(value: ex.Message);
//}
//// **************************************************

//// **************************************************
////try
////{
////	using var applicationDbContext = new ApplicationDbContext();

////	// دستور ذیل را خیلی پیشنهاد نمی‌کنم
////	// توصیه می‌کنم که به جای دستور ذیل
////	// استفاده گردد FirstOrDefault از دستور
////	var category =
////		applicationDbContext.Categories
////		.Find(keyValues: 1);

////	// دستور ذیل را خیلی پیشنهاد نمی‌کنم
////	//var category =
////	//	applicationDbContext.Categories
////	//	.FirstOrDefault(predicate: x => x.Id == 1);

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: x => x.Id == 1)
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: cagetory => cagetory.Id == 1)
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(current => current.Id == 1)
////	//	.FirstOrDefault();

////	if (category is null)
////	{
////		Console.WriteLine
////			(value: "There is not any category!");
////	}
////	else
////	{
////		Console.WriteLine(value: category.ToString());
////	}
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
////		applicationDbContext.Categories
////		.Where(predicate: current => current.Name == "My Category")
////		.FirstOrDefault();
////	//.ToList(); // بعدا آموزش داده می‌شود

////	// کار می‌کرد EF دستور ذیل در
////	// کار نمی‌کند EF Core ولی متاسفانه، در
////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => string.Compare(current.Name, "My Category", true) == 0)
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => current.Name.ToLower() == "My Category".ToLower()) // OR ToUppoer()
////	//	.FirstOrDefault();

////	// دستور ذیل کار نمی‌کند
////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => current.Name is not null
////	//		&& current.Name.ToLower() == "My Category".ToLower())
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => current.Name != null
////	//		&& current.Name.ToLower() == "My Category".ToLower())
////	//	.FirstOrDefault();

////	// Note: متاسفانه دستور ذیل کار نمی‌کند
////	// StartsWith(value: "My") -> value:
////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => current.Name != null &&
////	//		current.Name.ToLower().StartsWith(value: "My".ToLower()))
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate:
////	//		current => current.Name != null
////	//		&& current.Name.ToLower().StartsWith("My".ToLower()))
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => current.Name != null
////	//		&& current.Name.ToLower().EndsWith("Category".ToLower()))
////	//	.FirstOrDefault();

////	//var category =
////	//	applicationDbContext.Categories
////	//	.Where(predicate: current => current.Name != null
////	//		&& current.Name.ToLower().Contains("Category".ToLower()))
////	//	.FirstOrDefault();

////	if (category is null)
////	{
////		Console.WriteLine
////			(value: "There is not any category!");
////	}
////	else
////	{
////		Console.WriteLine(value: category.ToString());
////	}
////}
////catch (Exception ex)
////{
////	Console.WriteLine(value: ex.Message);
////}
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
//	public override string ToString()
//	{
//		//var result =
//		//	$"Id: {Id} - Name: {Name}";

//		var result =
//			$"{nameof(Id)}: {Id} - {nameof(Name)}: {Name}";

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

//	protected override void OnConfiguring
//		(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		optionsBuilder.UseSqlServer
//			(connectionString: connectionString);
//	}
//}
