﻿//using System;
//using System.Linq;
//using System.Diagnostics;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//try
//{
//	var username =
//		$"DariushTasdighi";

//	var groupName = "Managers";

//	{
//		using var applicationDbContext = new ApplicationDbContext();

//		var hasAnyUser =
//			await
//			applicationDbContext.Users.AnyAsync();

//		if (hasAnyUser == false)
//		{
//			var newUser =
//				new User(username: username);

//			applicationDbContext.Add(entity: newUser);

//			await applicationDbContext.SaveChangesAsync();
//		}

//		var hasAnyGroup =
//			await
//			applicationDbContext.Groups.AnyAsync();

//		if (hasAnyGroup == false)
//		{
//			var newGroup =
//				new Group(name: groupName);

//			applicationDbContext.Add(entity: newGroup);

//			await applicationDbContext.SaveChangesAsync();
//		}
//	}

//	{
//		using var applicationDbContext = new ApplicationDbContext();

//		var theUser =
//			await
//			applicationDbContext.Users
//			.Where(current => current.Username.ToLower() == username.ToLower())
//			.FirstOrDefaultAsync();

//		if (theUser is null)
//		{
//			Console.WriteLine
//				(value: $"There is not the {username} user!");

//			return;
//		}

//		var theGroup =
//			await
//			applicationDbContext.Groups
//			.Where(current => current.Name.ToLower() == groupName.ToLower())
//			.FirstOrDefaultAsync();

//		if (theGroup is null)
//		{
//			Console.WriteLine
//				(value: $"There is not the {groupName} group!");

//			return;
//		}

//		theGroup.Users.Add(item: theUser);
//		// [OR]
//		theUser.Groups.Add(item: theGroup);

//		var affectedRows =
//			await
//			applicationDbContext.SaveChangesAsync();

//		Console.WriteLine
//			(value: $"{nameof(affectedRows)}: {affectedRows}");
//	}
//}
//catch (Exception ex)
//{
//	Console.WriteLine(value: ex.Message);
//}

//public abstract class Entity : object
//{
//	[Key]
//	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
//	public DateTimeOffset InsertDateTime { get; private set; } = DateTimeOffset.Now;
//}

//public class User(string username) : Entity
//{
//	[MaxLength(length: 20)]
//	[Required(AllowEmptyStrings = false)]
//	public string Username { get; set; } = username;

//	public virtual IList<Group> Groups { get; } = [];
//}

//public class Group(string name) : Entity
//{
//	[MaxLength(length: 50)]
//	[Required(AllowEmptyStrings = false)]
//	public string Name { get; set; } = name;

//	public virtual IList<User> Users { get; } = [];
//}

//internal class UserConfiguration : object, IEntityTypeConfiguration<User>
//{
//	public UserConfiguration() : base()
//	{
//	}

//	public void Configure(EntityTypeBuilder<User> builder)
//	{
//		builder
//			.HasKey(current => current.Id)
//			.IsClustered(clustered: false)
//			;

//		builder
//			.Property(current => current.Username)
//			.IsUnicode(unicode: false)
//			;

//		builder
//			.HasIndex(current => new { current.Username })
//			.IsUnique(unique: true)
//			;

//		builder
//			.HasMany(current => current.Groups)
//			.WithMany(other => other.Users)
//			.UsingEntity
//			(
//				"UsersInGroups",
//				// ترتیب نوشتن دو دستور ذیل، بینهایت اهمیت دارد
//				// نزدیک در نزدیک - دور در دور
//				left => left.HasOne(typeof(Group)).WithMany().HasForeignKey("GroupId").HasPrincipalKey(nameof(Group.Id)),
//				right => right.HasOne(typeof(User)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(User.Id)),
//				join => join.HasKey("GroupId", "UserId")
//			);

//		// نکته: دو دستور ذیل با هم فرق می‌کنند
//		//join => join.HasKey("GroupId", "UserId")
//		//join => join.HasKey("UserId", "GroupId")

//		// اگر بخواهیم به صورت ساده‌ای بنویسیم که در اکثر مواقع کار کند
//		//builder
//		//	.HasMany(current => current.Groups)
//		//	.WithMany(other => other.Users)
//		//	.UsingEntity
//		//	(
//		//		"UsersInGroups",
//		//		left => left.HasOne(typeof(Group)).WithMany().HasForeignKey("GroupId"),
//		//		right => right.HasOne(typeof(User)).WithMany().HasForeignKey("UserId")
//		//	);
//	}
//}

//internal class GroupConfiguration : object, IEntityTypeConfiguration<Group>
//{
//	public GroupConfiguration() : base()
//	{
//	}

//	public void Configure(EntityTypeBuilder<Group> builder)
//	{
//		builder
//			.HasKey(current => current.Id)
//			.IsClustered(clustered: false)
//			;

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

//	public DbSet<User> Users { get; set; }
//	public DbSet<Group> Groups { get; set; }

//	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0300;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		// New!
//		//optionsBuilder
//		//	.LogTo(e => Debug.WriteLine(e))
//		//	;

//		// [OR]

//		// New!
//		//optionsBuilder
//		//	.LogTo(e => Console.WriteLine(e))
//		//	;

//		// [OR]

//		// New!
//		//optionsBuilder
//		//	.LogTo(action: Console.WriteLine)
//		//	;

//		//optionsBuilder
//		//	.UseSqlServer(connectionString: connectionString)
//		//	;

//		// [OR]
//		optionsBuilder
//			.LogTo(action: Console.WriteLine)
//			.UseSqlServer(connectionString: connectionString)
//			;
//	}

//	protected override void OnModelCreating(ModelBuilder modelBuilder)
//	{
//		modelBuilder.ApplyConfigurationsFromAssembly
//			(assembly: typeof(ApplicationDbContext).Assembly);
//	}
//}
