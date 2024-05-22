using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

try
{
	{
		using var applicationDbContext = new ApplicationDbContext();

		var hasAnyCategory =
			await
			applicationDbContext.Roles.AnyAsync();

		if (hasAnyCategory == false)
		{
			var category =
				new Role(name: $"Administrator");

			applicationDbContext.Add(entity: category);

			await applicationDbContext.SaveChangesAsync();
		}
	}

	{
		using var applicationDbContext = new ApplicationDbContext();

		var foundedCategory =
			await
			applicationDbContext.Roles
			.Where(current => current.Name.ToLower() == "Administrator".ToLower())
			.FirstOrDefaultAsync();

		if (foundedCategory is null)
		{
			var errorMessage =
				$"Role not found!";

			Console.WriteLine(value: errorMessage);

			return;
		}


	}
	// **************************************************
}
catch (Exception ex)
{
	Console.WriteLine(value: ex.Message);
}

public abstract class Entity() : object()
{
	[Key]
	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public Guid Id { get; private set; } = Guid.NewGuid();

	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public DateTimeOffset InsertDateTime { get; private set; } = DateTime.Now;
}

public class Role(string name) : Entity()
{
	[MaxLength(length: 100)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;

	public virtual IList<User> Users { get; } = [];
}

public class User(string username, Guid roleId) : Entity()
{
	[Required]
	public virtual Role? Role { get; set; }

	[Required]
	public Guid RoleId { get; set; } = roleId;

	[MaxLength(length: 20)]
	[Required(AllowEmptyStrings = false)]
	public string Username { get; set; } = username;
}

internal class RoleConfiguration :
	object, IEntityTypeConfiguration<Role>
{
	public RoleConfiguration() : base()
	{
	}

	public void Configure(EntityTypeBuilder<Role> builder)
	{
		builder
			.HasKey(current => current.Id)
			.IsClustered(clustered: false)
			;

		builder
			.Property(current => current.Name)
			.IsUnicode(unicode: false)
			;

		builder
			.HasIndex(current => new { current.Name })
			.IsUnique(unique: true)
			;
	}
}

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext() : base()
	{
		Database.EnsureCreated();
	}

	public DbSet<Role> Roles { get; set; }
	public DbSet<User> Users { get; set; }

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0300;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly
			(assembly: typeof(ApplicationDbContext).Assembly);
	}
}
