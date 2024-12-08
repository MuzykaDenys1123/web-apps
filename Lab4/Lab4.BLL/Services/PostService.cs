using Lab4.BLL.DTOs.Comments;
using Lab4.BLL.DTOs.Posts;
using Lab4.BLL.Services.Abstractions;
using Lab4.DAL.Entities;
using Lab4.DAL.Repositories;

namespace Lab4.BLL.Services;
public class PostService : IPostService
{
    private readonly IPostRepository _repository;

    public PostService(IPostRepository repository)
    {
        _repository = repository;
    }

    public async Task CreateAsync(CreatePostDTO createDTO)
    {
        var post = new Post
        {
            Text = createDTO.Text,
            Title = createDTO.Title,
            Type = createDTO.Type,
            CreatedDate = DateTime.UtcNow,
        };

        await _repository.CreateAsync(post);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task<ICollection<PostDTO>> GetAllAsync()
    {
        var posts = await _repository.GetAllAsync();

        return posts.Select(post => new PostDTO
        {
            Id = post.Id,
            Title = post.Title,
            Text = post.Text,
            Type = post.Type,
            Comments = post.Comments.Select(comment => new CommentDTO
            {
                Id = comment.Id,
                Text = comment.Text,
                PostId = post.Id
            }).ToList()
        }).ToList();
    }

    public async Task<PostDTO> GetByIdAsync(int id)
    {
        var post = await _repository.GetByIdAsync(id);

        return new PostDTO
        {
            Id = post.Id,
            Title = post.Title,
            Text = post.Text,
            Type = post.Type,
            Comments = post.Comments.Select(comment => new CommentDTO
            {
                Id = comment.Id,
                Text = comment.Text,
                PostId = post.Id
            }).ToList()
        };
    }

    public async Task UpdateAsync(UpdatePostDTO updateDTO)
    {
       var post = await _repository.GetByIdAsync(updateDTO.Id);

       post.Title = updateDTO.Title;
       post.Text = updateDTO.Text;
       post.Type = updateDTO.Type;

       _repository.Update(post);

       await _repository.SaveChangesAsync();
    }
}
