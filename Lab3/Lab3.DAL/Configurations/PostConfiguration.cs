using Lab3.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab3.DAL.Configurations;

internal class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasMany(p => p.Comments)
               .WithOne(p => p.Post);

        builder.Property(p => p.Type)
               .HasConversion<string>();
    }
}
