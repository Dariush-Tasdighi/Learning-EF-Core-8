﻿//using System;
//using System.Linq;
//using System.Reflection;
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//try
//{
//	{
//		using var applicationDbContext = new ApplicationDbContext();

//		var hasAnyCategory =
//			// New
//			await
//			applicationDbContext.Categories.AnyAsync();

//		if (hasAnyCategory == false)
//		{
//			for (var index = 1; index <= 9; index++)
//			{
//				var category =
//					new Category(name: $"Category {index}")
//					{
//						IsActive = (index % 2 == 0),
//					};

//				// New
//				// GenerationStrategy.SequenceHiLo
//				// کندتر است Add() در صورتی که از امکان فوق نمی‌خواهیم استفاده کنیم، از
//				//await applicationDbContext.AddAsync(entity: category);

//				applicationDbContext.Add(entity: category);

//				// New
//				await applicationDbContext.SaveChangesAsync();
//			}
//		}
//	}

//	{
//		using var applicationDbContext = new ApplicationDbContext();

//		var foundCategory =
//			// New
//			await
//			applicationDbContext.Categories
//			.Where(current => current.Name.ToLower() == "Category 1".ToLower())
//			// New
//			.FirstOrDefaultAsync();

//		if (foundCategory is null)
//		{
//			var errorMessage =
//				$"Category not found!";

//			Console.WriteLine(value: errorMessage);
//		}
//		else
//		{
//			foundCategory.IsActive = true;

//			var affectedRows =
//				await
//				applicationDbContext.SaveChangesAsync();
//		}
//	}
//	// **************************************************
//}
//catch (Exception ex)
//{
//	Console.WriteLine(value: ex.Message);
//}


//// **************************************************
//// **************************************************
//// **************************************************
////public class Category : object
////{
////	public Category() : base()
////	{
////	}

////	public int Id { get; set; }

////	//...
////	//...
////	//...
////}
//// **************************************************
//// **************************************************
//// **************************************************


//// **************************************************
//// **************************************************
//// **************************************************
////public abstract class Entity : object
////{
////	protected Entity() : base()
////	{
////		// غلط
////		//Id = new Guid();

////		Id = Guid.NewGuid();

////		InsertDateTime = DateTime.Now;
////	}

////	public Guid Id { get; private set; }

////	//public int Id { get; private set; }

////	//public long Id { get; private set; }

////	//public DateTime InsertDateTime { get; private set; }
////	public DateTimeOffset InsertDateTime { get; private set; }
////}
//// **************************************************
//// **************************************************
//// **************************************************


//// **************************************************
//// **************************************************
//// **************************************************
////public abstract class Entity : object
////{
////	[Key]
////	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
////	public Guid Id { get; private set; } = Guid.NewGuid();

////	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
////	public DateTimeOffset InsertDateTime { get; private set; } = DateTime.Now;

////	public void SomeFunction()
////	{
////		Id = Guid.NewGuid();
////	}
////}
//// **************************************************
//// **************************************************
//// **************************************************


//// **************************************************
//// **************************************************
//// **************************************************
////public abstract class Entity : object
//////public abstract class Entity() : object()
////{
////	[Key]
////	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
////	public Guid Id { get; init; } = Guid.NewGuid();

////	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
////	public DateTimeOffset InsertDateTime { get; init; } = DateTime.Now;

////	//public void SomeFunction()
////	//{
////	//	Id = Guid.NewGuid(); // Error!
////	//}
////}

////public class Category : Entity
////{
////	public Category(string name) : base()
////	{
////		Name = name;
////	}

////	public bool IsActive { get; set; }

////	//[Required]
////	[Required(AllowEmptyStrings = false)]
////	[MaxLength(length: 100)]
////	public string Name { get; set; }

////	public override string ToString()
////	{
////		var result =
////			$"{nameof(Id)}: {Id} - {nameof(Name)}: {Name} - {nameof(IsActive)}: {IsActive}";

////		return result;
////	}
////}
//// **************************************************
//// **************************************************
//// **************************************************


//// **************************************************
//// **************************************************
//// **************************************************
//public abstract class Entity : object
//{
//	[Key]
//	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
//	public Guid Id { get; init; } = Guid.NewGuid();

//	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
//	public DateTimeOffset InsertDateTime { get; init; } = DateTime.Now;
//}

//public class Category(string name) : Entity
//{
//	public bool IsActive { get; set; }

//	[MaxLength(length: 100)]
//	[Required(AllowEmptyStrings = false)]
//	public string Name { get; set; } = name;

//	public override string ToString()
//	{
//		var result =
//			$"{nameof(Id)}: {Id} - {nameof(Name)}: {Name} - {nameof(IsActive)}: {IsActive}";

//		return result;
//	}
//}
//// **************************************************
//// **************************************************
//// **************************************************

///// <summary>
///// Fluent API
///// </summary>
//internal class CategoryConfiguration :
//	object, IEntityTypeConfiguration<Category>
//{
//	public CategoryConfiguration() : base()
//	{
//	}

//	public void Configure(EntityTypeBuilder<Category> builder)
//	{
//		builder
//			.HasKey(current => current.Id)
//			// مهم
//			// https://www.youtube.com/watch?v=n17U7ntLMt4&t=803s
//			.IsClustered(clustered: false)
//			;

//		builder
//			.Property(current => current.Name)
//			.IsUnicode(unicode: false)
//			;

//		// Alternate Key: Name
//		//builder
//		//	.HasIndex(current => current.Name)
//		//	.IsUnique(unique: true)
//		//	;

//		// Best Practice
//		builder
//			.HasIndex(current => new { current.Name })
//			.IsUnique(unique: true)
//			;
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

//	//protected override void OnModelCreating(ModelBuilder modelBuilder)
//	//{
//	//	base.OnModelCreating(modelBuilder);
//	//}

//	protected override void OnModelCreating(ModelBuilder modelBuilder)
//	{
//		// ویژگی‌ها تجمیع می‌شوند
//		// مشترک‌ها، چیزی که آخر نوشته می‌شود

//		// Solution (1)
//		//modelBuilder
//		//	.Entity<Category>()
//		//	.Property(current => current.Name)
//		//	.IsUnicode(unicode: false)
//		//	;
//		// /Solution (1)

//		// Solution (2)
//		//modelBuilder.ApplyConfiguration
//		//	(configuration: new CategoryConfiguration());
//		// /Solution (2)

//		// Solution (3)
//		//new CategoryConfiguration()
//		//	.Configure(builder: modelBuilder.Entity<Category>());
//		// /Solution (3)

//		// Solution (4)
//		//modelBuilder.ApplyConfigurationsFromAssembly
//		//	(assembly: Assembly.GetExecutingAssembly());
//		// /Solution (4)

//		// Solution (5)
//		//modelBuilder.ApplyConfigurationsFromAssembly
//		//	(assembly: typeof(CategoryConfiguration).Assembly);
//		// /Solution (5)

//		// Solution (6)
//		modelBuilder.ApplyConfigurationsFromAssembly
//			(assembly: typeof(ApplicationDbContext).Assembly);
//		// /Solution (6)
//	}
//}
