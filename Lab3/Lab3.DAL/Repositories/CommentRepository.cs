using Lab3.DAL.Context;
using Lab3.DAL.Entities;

namespace Lab3.DAL.Repositories;

public class CommentRepository : GenericRepository<Comment, int>, ICommentRepository
{
    public CommentRepository(ProgrammingBlogContext context) : base(context)
    {
    }
}
