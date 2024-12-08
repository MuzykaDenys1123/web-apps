using Lab3.DAL.Entities;

namespace Lab3.BLL.DTOs.Comments;

public class CommentDTO
{
    public int Id { get; set; }

    public string Text { get; set; }

    public int PostId { get; set; }

}
