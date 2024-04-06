using System;
using System.Linq;
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
			applicationDbContext.Categories.AnyAsync();

		if (hasAnyCategory == false)
		{
			for (var index = 1; index <= 9; index++)
			{
				var category =
					new Category(name: $"Category {index}")
					{
						IsActive = (index % 2 == 0),
					};

				applicationDbContext.Add(entity: category);

				await applicationDbContext.SaveChangesAsync();
			}
		}
	}

	{
		using var applicationDbContext = new ApplicationDbContext();

		Category? foundedCategory;

		// **************************************************
		// برمی‌گرداند null ،اگر پیدا نکند
		// اگر فقط یکی پیدا کند، همان یکی را برمی‌گرداند
		// اگر بیش از یکی پیدا کند، اولین آن‌را برمی‌گرداند
		// **************************************************
		foundedCategory =
			applicationDbContext.Categories
			.FirstOrDefault();

		// New in EF Core
		foundedCategory =
			await
			applicationDbContext.Categories
			.FirstOrDefaultAsync();
		// **************************************************

		// **************************************************
		// اگر پیدا نکند، خطا تولید می‌کند
		// اگر فقط یکی پیدا کند، همان یکی را برمی‌گرداند
		// اگر بیش از یکی پیدا کند، اولین آن‌را برمی‌گرداند
		// **************************************************
		foundedCategory =
			applicationDbContext.Categories
			.First();

		// New in EF Core
		foundedCategory =
			await
			applicationDbContext.Categories
			.FirstAsync();
		// **************************************************

		// **************************************************
		// برمی‌گرداند null ،اگر پیدا نکند
		// اگر فقط یکی پیدا کند، همان یکی را برمی‌گرداند
		// اگر بیش از یکی پیدا کند، آخرین آن‌را برمی‌گرداند
		// **************************************************
		foundedCategory =
			applicationDbContext.Categories
			.LastOrDefault();

		// New in EF Core
		foundedCategory =
			await
			applicationDbContext.Categories
			.LastOrDefaultAsync();
		// **************************************************

		// **************************************************
		// اگر پیدا نکند، خطا تولید می‌کند
		// اگر فقط یکی پیدا کند، همان یکی را برمی‌گرداند
		// اگر بیش از یکی پیدا کند، آخرین آن‌را برمی‌گرداند
		// **************************************************
		foundedCategory =
			applicationDbContext.Categories
			.Last();

		// New in EF Core
		foundedCategory =
			await
			applicationDbContext.Categories
			.LastAsync();
		// **************************************************

		// **************************************************
		// برمی‌گرداند null ،اگر پیدا نکند
		// اگر فقط یکی پیدا کند، همان یکی را برمی‌گرداند
		// اگر بیش از یکی پیدا کند، خطا تولید می‌کند
		// **************************************************
		foundedCategory =
			applicationDbContext.Categories
			.SingleOrDefault();

		// New in EF Core
		foundedCategory =
			await
			applicationDbContext.Categories
			.SingleOrDefaultAsync();
		// **************************************************

		// **************************************************
		// اگر پیدا نکند، خطا تولید می‌کند
		// اگر فقط یکی پیدا کند، همان یکی را برمی‌گرداند
		// اگر بیش از یکی پیدا کند، خطا تولید می‌کند
		// **************************************************
		foundedCategory =
			applicationDbContext.Categories
			.Single();

		// New in EF Core
		foundedCategory =
			await
			applicationDbContext.Categories
			.SingleAsync();
		// **************************************************

		if (foundedCategory is null)
		{
			var errorMessage =
				$"Category not found!";

			Console.WriteLine(value: errorMessage);
		}
		else
		{
			foundedCategory.IsActive = true;

			var affectedRows =
				await
				applicationDbContext.SaveChangesAsync();
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

	[DatabaseGenerated
		(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public Guid Id { get; private set; } = Guid.NewGuid();

	[DatabaseGenerated
		(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public DateTimeOffset InsertDateTime { get; private set; } = DateTime.Now;
}

public class Category(string name) : Entity()
{
	public bool IsActive { get; set; }

	[MaxLength(length: 100)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;

	public override string ToString()
	{
		var result =
			$"{nameof(Id)}: {Id} - {nameof(Name)}: {Name} - {nameof(IsActive)}: {IsActive}";

		return result;
	}
}

internal class CategoryConfiguration :
	object, IEntityTypeConfiguration<Category>
{
	public CategoryConfiguration() : base()
	{
	}

	public void Configure(EntityTypeBuilder<Category> builder)
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

	public DbSet<Category> Categories { get; set; }

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly
			(assembly: typeof(ApplicationDbContext).Assembly);
	}
}
