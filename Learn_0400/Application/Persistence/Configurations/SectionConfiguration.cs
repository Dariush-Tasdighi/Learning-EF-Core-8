using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Persistence.Configurations;

internal sealed class SectionConfiguration : object, IEntityTypeConfiguration<Section>
{
	public void Configure(EntityTypeBuilder<Section> builder)
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
	}
}
