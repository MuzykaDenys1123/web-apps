using Lab3.BLL.DTOs.Comments;
using Lab3.BLL.Services.Abstractions;
using Lab3.DAL.Entities;
using Lab3.DAL.Repositories;

namespace Lab3.BLL.Services;

public class CommentService : ICommentService
{
    public readonly ICommentRepository _repository;

    public CommentService(ICommentRepository repository)
    {
        _repository = repository;
    }

    public async Task CreateAsync(CreateCommentDTO createDTO)
    {
        var comment = new Comment
        {
            PostId = createDTO.PostId,
            Text = createDTO.Text,
            CreateDate = DateTime.UtcNow,
        };

        await _repository.CreateAsync(comment);

        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task<CommentDTO> GetByIdAsync(int id)
    {
        var comment = await _repository.GetByIdAsync(id);

        return new CommentDTO { Id =  comment.Id, Text = comment.Text, PostId = comment.PostId };
    }

    public async Task UpdateAsync(UpdateCommentDTO updateDTO)
    {
        var comment = await _repository.GetByIdAsync(updateDTO.Id);

        comment.Text = updateDTO.Text;
        comment.PostId = updateDTO.PostId;

        _repository.Update(comment);

        await _repository.SaveChangesAsync();
    }
}
