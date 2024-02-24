//var applicationDbContext =
//	new ApplicationDbContext();

//var category =
//	new Category
//	{
//		Name = "My Category",
//	};

//applicationDbContext.Categories.Add(entity: category);

//applicationDbContext.SaveChanges();

//applicationDbContext.Dispose();
////applicationDbContext = null; // !دیگر نیازی نیست

///// <summary>
///// In Separate File and Folder!
///// </summary>
//public class Category : object
//{
//	public Category() : base()
//	{
//	}

//	public int Id { get; set; }

//	public string? Name { get; set; }
//}

///// <summary>
///// In Separate File and Folder!
/////
///// DatabaseContext -> استاندارد قبلی من
///// </summary>
//public class ApplicationDbContext :
//	Microsoft.EntityFrameworkCore.DbContext
//{
//	public ApplicationDbContext() : base()
//	{
//	}

//	/// <summary>
//	/// Table Name -> Categories
//	/// </summary>
//	public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }
//}
