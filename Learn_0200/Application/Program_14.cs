﻿//using System;
//using Resources;
//using Resources.Messages;
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//{
//	try
//	{
//		using var applicationDbContext = new ApplicationDbContext();
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(value: ex.Message);
//	}
//}

//// **************************************************
//// *** User 01 **************************************
//// **************************************************
//[Index(nameof(Username), IsUnique = true)]
//[Index(nameof(FirstName), nameof(LastName), IsUnique = false)]
//public class User01(string username) : object
//{
//	[Key]
//	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	//[Range(minimum: 1, maximum: 100_000)]

//	//[Range(minimum: 1, maximum: 100_000,
//	//	ErrorMessage = "The Ordering value should be between 1 and 100000!")]

//	[Range(minimum: 1, maximum: 100_000, ErrorMessage =
//		"The {0} value should be between {1} and {2}!")]

//	// و البته روش حرفه‌ای‌تر و هیجان‌انگیزتری که در ادامه خواهیم دید
//	public int Ordering { get; set; } = 10_000;

//	[MaxLength(length: 20)]
//	[Required(AllowEmptyStrings = false)]
//	public string Username { get; set; } = username;

//	[MaxLength(length: 30, ErrorMessage =
//		"The {0} value must be a string with a maximum length of '{1}'!")]
//	public string? LastName { get; set; }

//	[Display(Name = "First Name")]
//	[MaxLength(length: 20, ErrorMessage =
//		"The {0} value must be a string with a maximum length of '{1}'!")]
//	public string? FirstName { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** User 02 **************************************
//// **************************************************
//[Index(nameof(Username), IsUnique = true)]
//[Index(nameof(FirstName), nameof(LastName), IsUnique = false)]
//public class User02(string username) : object
//{
//	//[System.ComponentModel.DataAnnotations.Display
//	//	(Name = "Identity")]

//	//[System.ComponentModel.DataAnnotations.Display
//	//	(Name = "شناسه")]

//	//[System.ComponentModel.DataAnnotations.Display
//	//	(ResourceType = typeof(DataDictionary),
//	//	Name = "Id")]

//	// سوتی می‌دهم
//	//[System.ComponentModel.DataAnnotations.Display
//	//	(ResourceType = typeof(DataDictionary),
//	//	Name = "Idd")]

//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	[Display(ResourceType =
//		typeof(DataDictionary),
//		Name = nameof(DataDictionary.Id))]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	[Display(ResourceType =
//		typeof(DataDictionary),
//		Name = nameof(DataDictionary.Ordering))]
//	[Range(minimum: 1, maximum: 100_000,
//		ErrorMessageResourceType = typeof(Validations),
//		ErrorMessageResourceName = nameof(Validations.Range))]
//	public int Ordering { get; set; } = 10_000;

//	[Display(ResourceType =
//		typeof(DataDictionary),
//		Name = nameof(DataDictionary.Username))]
//	[Required(AllowEmptyStrings = false,
//		ErrorMessageResourceType = typeof(Validations),
//		ErrorMessageResourceName = nameof(Validations.Required))]
//	[MaxLength(length: 20,
//		ErrorMessageResourceType = typeof(Validations),
//		ErrorMessageResourceName = nameof(Validations.MaxLength))]
//	public string Username { get; set; } = username;

//	[Display(ResourceType =
//		typeof(DataDictionary),
//		Name = nameof(DataDictionary.LastName))]
//	[MaxLength(length: 30,
//		ErrorMessageResourceType = typeof(Validations),
//		ErrorMessageResourceName = nameof(Validations.MaxLength))]
//	public string? LastName { get; set; }

//	[Display(ResourceType =
//		typeof(DataDictionary),
//		Name = nameof(DataDictionary.FirstName))]
//	[MaxLength(length: 20,
//		ErrorMessageResourceType = typeof(Validations),
//		ErrorMessageResourceName = nameof(Validations.MaxLength))]
//	public string? FirstName { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//public class ApplicationDbContext : DbContext
//{
//	public ApplicationDbContext() : base()
//	{
//		Database.EnsureCreated();
//	}
//	public DbSet<User01> Users_01 { get; set; }
//	public DbSet<User02> Users_02 { get; set; }

//	protected override void OnConfiguring
//		(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		optionsBuilder.UseSqlServer
//			(connectionString: connectionString);
//	}
//	protected override void OnModelCreating(ModelBuilder modelBuilder)
//	{
//		modelBuilder.ApplyConfigurationsFromAssembly
//			(assembly: typeof(ApplicationDbContext).Assembly);
//	}
//}
