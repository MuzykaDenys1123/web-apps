using Lab3.DAL.Enums;

namespace Lab3.BLL.DTOs.Posts;

public record UpdatePostDTO(int Id, string Title, string Text, PostType Type)
{
}
