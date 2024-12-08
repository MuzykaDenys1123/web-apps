using Lab3.BLL.DTOs.Comments;

namespace Lab3.BLL.Services.Abstractions;

public interface ICommentService
{
    Task CreateAsync(CreateCommentDTO createDTO);

    Task UpdateAsync(UpdateCommentDTO updateDTO);

    Task<CommentDTO> GetByIdAsync(int id);

    Task DeleteAsync(int id);
}
