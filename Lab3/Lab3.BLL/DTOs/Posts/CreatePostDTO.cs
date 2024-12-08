using Lab3.DAL.Enums;

namespace Lab3.BLL.DTOs.Posts;

public record CreatePostDTO(string Title, string Text, PostType Type)
{
}
