﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Persistence.Configurations;

internal sealed class CityConfiguration : object, IEntityTypeConfiguration<City>
{
	public void Configure(EntityTypeBuilder<City> builder)
	{
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
