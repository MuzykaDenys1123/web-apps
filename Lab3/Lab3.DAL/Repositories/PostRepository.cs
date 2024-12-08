using Lab3.DAL.Context;
using Lab3.DAL.Entities;

namespace Lab3.DAL.Repositories;

public class PostRepository : GenericRepository<Post, int>, IPostRepository
{
    public PostRepository(ProgrammingBlogContext context) : base(context)
    {
    }
}
