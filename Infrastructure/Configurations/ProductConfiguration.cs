using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");
        builder.HasKey(e => e.Id).HasName("PRIMARY");
        builder.HasIndex(e => e.BrandId, "IX_Product_BrandId");
        builder.HasIndex(e => e.CategoryId, "IX_Product_CategoryId");
        builder.Property(e => e.CreationDate).HasMaxLength(6);
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Price).HasPrecision(18, 2);
        builder.HasOne(d => d.Brand).WithMany(p => p.Products).HasForeignKey(d => d.BrandId);
        builder.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
    }
}
