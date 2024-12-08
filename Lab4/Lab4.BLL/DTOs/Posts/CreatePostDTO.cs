using Lab4.DAL.Enums;

namespace Lab4.BLL.DTOs.Posts;

public record CreatePostDTO(string Title, string Text, PostType Type)
{
}
