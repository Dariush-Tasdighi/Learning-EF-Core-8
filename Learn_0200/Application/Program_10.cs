//using System;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//try
//{
//	{
//		using var applicationDbContext = new ApplicationDbContext();

//		var hasAnyCategory =
//			applicationDbContext.Categories.Any();

//		if (hasAnyCategory == false)
//		{
//			for (var index = 1; index <= 9; index++)
//			{
//				var category =
//					new Category
//					{
//						Name = $"Category {index}",
//						IsActive = (index % 2 == 0),
//					};

//				applicationDbContext.Add(entity: category);

//				applicationDbContext.SaveChanges();
//			}
//		}
//	}

//	// **************************************************
//	// Update
//	// **************************************************
//	{
//		using var applicationDbContext = new ApplicationDbContext();

//		var foundCategory =
//			applicationDbContext.Categories
//			.Where(current => current.Id == 1)
//			.FirstOrDefault();

//		if (foundCategory is null)
//		{
//			var errorMessage =
//				$"There is not any category with this Id (1)!";

//			Console.WriteLine(value: errorMessage);
//		}
//		else
//		{
//			// Unchanged
//			var state1 =
//				applicationDbContext.Entry(entity: foundCategory).State;

//			var originalName = foundCategory.Name;

//			foundCategory.Name = originalName;

//			// Unchanged
//			var state2 =
//				applicationDbContext.Entry(entity: foundCategory).State;

//			foundCategory.Name = "New Category Name";

//			// Modified
//			var state3 =
//				applicationDbContext.Entry(entity: foundCategory).State;

//			foundCategory.Name = originalName;

//			// Note: ?????
//			var state4 =
//				applicationDbContext.Entry(entity: foundCategory).State;

//			var affectedRows =
//				applicationDbContext.SaveChanges();

//			// Unchanged
//			var state6 =
//				applicationDbContext.Entry(entity: foundCategory).State;
//		}
//	}
//	// **************************************************

//	// **************************************************
//	// Update and then delete
//	// **************************************************
//	//{
//	//	using var applicationDbContext = new ApplicationDbContext();

//	//	var foundCategory =
//	//		applicationDbContext.Categories
//	//		.Where(current => current.Id == 1)
//	//		.FirstOrDefault();

//	//	if (foundCategory is null)
//	//	{
//	//		var errorMessage =
//	//			$"There is not any category with this Id (1)!";

//	//		Console.WriteLine(value: errorMessage);
//	//	}
//	//	else
//	//	{
//	//		// Unchanged
//	//		var state1 =
//	//			applicationDbContext.Entry(entity: foundCategory).State;

//	//		foundCategory.Name = "New Category Name";

//	//		// اصلا هزار بار، این رکورد را ویرایش می‌کنیم

//	//		// Modified
//	//		var state2 =
//	//			applicationDbContext.Entry(entity: foundCategory).State;

//	//		applicationDbContext.Remove(entity: foundCategory);

//	//		// Note: ?????
//	//		var state3 =
//	//			applicationDbContext.Entry(entity: foundCategory).State;

//	//		var affectedRows =
//	//			applicationDbContext.SaveChanges();

//	//		// Detached
//	//		var state6 =
//	//			applicationDbContext.Entry(entity: foundCategory).State;
//	//	}
//	//}
//	// **************************************************

//	// **************************************************
//	// Add (Insert)
//	// **************************************************
//	//{
//	//	using var applicationDbContext = new ApplicationDbContext();

//	//	var newCategory =
//	//		new Category
//	//		{
//	//			IsActive = true,
//	//			Name = "New Category",
//	//		};

//	//	// Detached
//	//	var state1 =
//	//		applicationDbContext.Entry(entity: newCategory).State;

//	//	applicationDbContext.Add(entity: newCategory);

//	//	// Added
//	//	var state2 =
//	//		applicationDbContext.Entry(entity: newCategory).State;

//	//	applicationDbContext.Remove(entity: newCategory);

//	//	// Note: ?????
//	//	var state3 =
//	//		applicationDbContext.Entry(entity: newCategory).State;

//	//	var affectedRows =
//	//		applicationDbContext.SaveChanges();

//	//	// Detached
//	//	var state4 =
//	//		applicationDbContext.Entry(entity: newCategory).State;
//	//}
//	// **************************************************
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

//	protected override void OnConfiguring
//		(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		optionsBuilder.UseSqlServer
//			(connectionString: connectionString);
//	}
//}
