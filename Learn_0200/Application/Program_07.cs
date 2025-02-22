﻿//using System;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//try
//{
//	using var applicationDbContext = new ApplicationDbContext();

//	var hasAnyCategory =
//		applicationDbContext.Categories.Any();

//	if (hasAnyCategory == false)
//	{
//		for (var index = 1; index <= 9; index++)
//		{
//			var category =
//				new Category
//				{
//					Name = $"Category {index}",
//					IsActive = (index % 2 == 0),
//				};

//			applicationDbContext.Add(entity: category);

//			applicationDbContext.SaveChanges();
//		}
//	}

//	// **********
//	// ToList() -> using System.Linq;
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories.ToList();
//	}
//	// **********

//	// **********
//	// آیین نگارش
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6 && current.IsActive)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	// Best Practice
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6)
//			.Where(current => current.IsActive)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	// برای نوشتن دستور ذیل، راه دیگری وجود ندارد
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6 || current.IsActive)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	{
//		var search = "Category";

//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6)
//			.Where(current => current.IsActive)
//			.Where(current => current.Name != null &&
//				current.Name.ToLower().Contains(search.ToLower()))
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	// نوشتن دستورات ذیل، با ترتیبی
//	// که نوشته شده است را توصیه نمی‌کنم
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.OrderBy(current => current.IsActive)
//			.Where(current => current.Id <= 6)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	// Best Practice
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6)
//			.OrderBy(current => current.IsActive)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6)
//			.OrderByDescending(current => current.IsActive)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	// دستور ذیل غلط است و درست کار نمی‌کند
//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6)
//			.OrderBy(current => current.IsActive)
//			.OrderBy(current => current.Name)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	{
//		var categories =
//			applicationDbContext.Categories
//			.Where(current => current.Id <= 6)
//			.OrderBy(current => current.IsActive)
//			.ThenBy(current => current.Name)
//			.ToList()
//			;

//		foreach (var category in categories)
//		{
//			Console.WriteLine(value: category.ToString());
//		}
//	}
//	// **********

//	// **********
//	// به طور خلاصه
//	//
//	// OrderBy
//	// ThenBy
//	// ThenBy...
//	//
//	// OrderByDescending
//	// ThenBy
//	// ThenBy...
//	//
//	// OrderBy
//	// ThenByDescending
//	// ThenBy...
//	//
//	// OrderByDescending
//	// ThenByDescending
//	// ThenBy...
//	// **********
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
