//using Microsoft.EntityFrameworkCore;

//var applicationDbContext =
//	new ApplicationDbContext();

//// **************************************************
//var category =
//	new Category
//	{
//		Name = "My Category 1",
//	};

//applicationDbContext.Categories.Add(entity: category);

//applicationDbContext.SaveChanges();

//var id = category.Id;
//// **************************************************

//// **************************************************
//category =
//	new Category
//	{
//		Name = "My Category 2",
//	};

//applicationDbContext.Categories.Add(entity: category);

//applicationDbContext.SaveChanges();

//id = category.Id;
//// **************************************************

//// **************************************************
//category =
//	new Category
//	{
//		Id = 100, // Error!
//		Name = "My Category 3",
//	};

//// خطا می‌دهد EF Core مقداردهی به آی‌دی، در
//// مشکلی نداشت و صرفا توجهی به مقدار ما نمی‌کرد EF ولی در

//// پیغام خطا:
//// Cannot insert explicit value for identity column
//// in table 'Categories' when IDENTITY_INSERT is set to OFF.

//applicationDbContext.Categories.Add(entity: category);

//applicationDbContext.SaveChanges();

//id = category.Id;
//// **************************************************

//applicationDbContext.Dispose();

//public class Category : object
//{
//	public Category() : base()
//	{
//	}

//	public int Id { get; set; }

//	public string? Name { get; set; }
//}

//public class ApplicationDbContext :
//	Microsoft.EntityFrameworkCore.DbContext
//{
//	/// <summary>
//	/// New
//	/// </summary>
//	public ApplicationDbContext() : base()
//	{
//		// TODO: Never use in production mode
//		// نکته بسیار مهم
//		// تا قبل از اولین نسخه‌ای که می‌خواهیم آن‌را منتشر نماییم
//		Database.EnsureCreated();
//	}

//	public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }

//	//protected override void OnConfiguring
//	//	(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
//	//{
//	//	base.OnConfiguring(optionsBuilder);
//	//}

//	/// <summary>
//	/// New
//	/// </summary>
//	protected override void OnConfiguring
//		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
//	{
//		// ******************************************************************
//		// https://www.connectionstrings.com/sql-server/
//		// Connect Timeout or Connection Timeout: Default: 15 Seconds
//		// ******************************************************************

//		// ******************************************************************
//		// *** Windows Authentication Mode without TrustServerCertificate ***
//		// ******************************************************************
//		//var connectionString =
//		//	"Server=.;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;Trusted_Connection=True;";
//		// ******************************************************************

//		// ***************************************************************
//		// *** Windows Authentication Mode with TrustServerCertificate ***
//		// ***************************************************************
//		//var connectionString =
//		//	"Server=.;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;";
//		// ******************************************************************

//		// *********************************************************************
//		// *** SQL Server Authentication Mode without TrustServerCertificate ***
//		// *********************************************************************
//		//var connectionString =
//		//	"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true";
//		// ******************************************************************

//		// ******************************************************************
//		// *** SQL Server Authentication Mode with TrustServerCertificate ***
//		// ******************************************************************
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";
//		// ******************************************************************

//		// UseSqlServer -> using Microsoft.EntityFrameworkCore;
//		optionsBuilder.UseSqlServer
//			(connectionString: connectionString);
//	}
//}
