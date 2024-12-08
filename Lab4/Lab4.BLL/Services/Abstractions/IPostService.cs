using Lab4.BLL.DTOs.Comments;
using Lab4.BLL.DTOs.Posts;

namespace Lab4.BLL.Services.Abstractions;

public interface IPostService
{
    Task CreateAsync(CreatePostDTO createDTO);

    Task UpdateAsync(UpdatePostDTO updateDTO);

    Task<ICollection<PostDTO>> GetAllAsync();

    Task<PostDTO> GetByIdAsync(int id);

    Task DeleteAsync(int id);
}
