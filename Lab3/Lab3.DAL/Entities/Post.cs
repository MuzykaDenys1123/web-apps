using Lab3.DAL.Enums;

namespace Lab3.DAL.Entities;

public class Post : DbEntity<int>
{
    public string Title { get; set; }

    public string Text { get; set; }

    public PostType Type { get; set; }

    public DateTime CreatedDate { get; set; }

    public ICollection<Comment> Comments { get; set; } = [];
}
