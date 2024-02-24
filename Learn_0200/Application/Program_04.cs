//using System;
//using Microsoft.EntityFrameworkCore;

//try
//{
//	using var applicationDbContext = new ApplicationDbContext();

//	var category =
//		new Category
//		{
//			Name = "My Category",
//		};

//	applicationDbContext.Add(entity: category);

//	applicationDbContext.SaveChanges();
//}
//catch (Exception ex)
//{
//	Console.WriteLine(value: ex.Message);
//}

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

//	protected override void OnConfiguring
//		(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		optionsBuilder.UseSqlServer
//			(connectionString: connectionString);
//	}
//}
