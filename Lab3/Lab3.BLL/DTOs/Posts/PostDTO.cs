using Lab3.BLL.DTOs.Comments;
using Lab3.DAL.Entities;
using Lab3.DAL.Enums;

namespace Lab3.BLL.DTOs.Posts;

public class PostDTO
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }

    public PostType Type { get; set; }

    public DateTime CreatedDate { get; set; }

    public ICollection<CommentDTO> Comments { get; set; } = [];
}
