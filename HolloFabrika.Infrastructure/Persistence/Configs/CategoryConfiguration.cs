using HolloFabrika.Feature.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HolloFabrika.Infrastructure.Persistence.Configs;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Name)
            .HasMaxLength(CategoryConstants.NameMaxLength)
            .IsRequired();

        builder
            .Property<byte[]>("TimeStamp")
            .IsRowVersion();
    }
}