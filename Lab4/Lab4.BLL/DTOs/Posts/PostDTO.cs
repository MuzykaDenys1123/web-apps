using Lab4.BLL.DTOs.Comments;
using Lab4.DAL.Enums;

namespace Lab4.BLL.DTOs.Posts;

public class PostDTO
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }

    public PostType Type { get; set; }

    public DateTime CreatedDate { get; set; }

    public ICollection<CommentDTO> Comments { get; set; } = [];
}
