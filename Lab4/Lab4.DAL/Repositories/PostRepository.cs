using Lab4.DAL.Context;
using Lab4.DAL.Entities;

namespace Lab4.DAL.Repositories;

public class PostRepository : GenericRepository<Post, int>, IPostRepository
{
    public PostRepository(ProgrammingBlogContext context) : base(context)
    {
    }
}
