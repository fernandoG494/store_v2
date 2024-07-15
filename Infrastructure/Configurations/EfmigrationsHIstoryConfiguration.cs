using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EfmigrationsHistoryConfiguration : IEntityTypeConfiguration<EfmigrationsHistory>
{
    public void Configure(EntityTypeBuilder<EfmigrationsHistory> builder)
    {
        builder.ToTable("__EFMigrationsHistory");
        builder.HasKey(e => e.MigrationId).HasName("PRIMARY");
        builder.Property(e => e.MigrationId).HasMaxLength(150);
        builder.Property(e => e.ProductVersion).HasMaxLength(32);
    }
}
