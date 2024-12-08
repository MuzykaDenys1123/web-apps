using Lab4.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab4.DAL.Configurations;

internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasOne(c => c.Post)
               .WithMany(p => p.Comments)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
