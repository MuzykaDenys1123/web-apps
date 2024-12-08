using Lab3.BLL.DTOs.Comments;
using Lab3.BLL.DTOs.Posts;

namespace Lab3.BLL.Services.Abstractions;

public interface IPostService
{
    Task CreateAsync(CreatePostDTO createDTO);

    Task UpdateAsync(UpdatePostDTO updateDTO);

    Task<ICollection<PostDTO>> GetAllAsync();

    Task<PostDTO> GetByIdAsync(int id);

    Task DeleteAsync(int id);
}
