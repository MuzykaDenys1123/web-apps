using Lab3.DAL.Configurations;
using Lab3.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DAL.Context;
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
