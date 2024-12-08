using Lab4.DAL.Configurations;
using Lab4.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab4.DAL.Context;
public class ProgrammingBlogContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    public DbSet<Comment> Comments { get; set; }

    public ProgrammingBlogContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
    }
}
