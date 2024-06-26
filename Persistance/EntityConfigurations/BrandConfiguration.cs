﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands").HasKey(b=>b.Id);

        builder.Property(b=>b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b=>b.Name).HasColumnName("Name").IsRequired();
        builder.Property(b=>b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");

        //marka isimleri tekrar edilmemesi için index oluşturuyoruz
        builder.HasIndex(indexExpression: b=>b.Name, name: "UK_Brands_Name").IsUnique();

        // ilişkiler
        builder.HasMany(b=>b.Models);
        

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}
