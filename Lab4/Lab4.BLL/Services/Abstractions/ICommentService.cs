using Lab4.BLL.DTOs.Comments;

namespace Lab4.BLL.Services.Abstractions;

public interface ICommentService
{
    Task CreateAsync(CreateCommentDTO createDTO);

    Task UpdateAsync(UpdateCommentDTO updateDTO);

    Task<CommentDTO> GetByIdAsync(int id);

    Task DeleteAsync(int id);
}
