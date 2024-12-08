using Lab4.DAL.Context;
using Lab4.DAL.Entities;

namespace Lab4.DAL.Repositories;

public class CommentRepository : GenericRepository<Comment, int>, ICommentRepository
{
    public CommentRepository(ProgrammingBlogContext context) : base(context)
    {
    }
}
