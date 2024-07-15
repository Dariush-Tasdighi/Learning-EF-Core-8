using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Persistence.Configurations;

internal sealed class StateConfiguration : object, IEntityTypeConfiguration<State>
{
	public void Configure(EntityTypeBuilder<State> builder)
	{
		// **************************************************
		builder
			.Property(current => current.Name)
			.IsUnicode(unicode: false)
			;

		builder
			.HasIndex(current => new { current.Name })
			.IsUnique(unique: true)
			;
		// **************************************************

		// **************************************************
		builder
			.HasMany(current => current.Cities)
			.WithOne(other => other.State)
			.IsRequired(required: true)
			.HasForeignKey(other => other.StateId)
			.OnDelete(deleteBehavior: DeleteBehavior.NoAction)
			;
		// **************************************************
	}
}
