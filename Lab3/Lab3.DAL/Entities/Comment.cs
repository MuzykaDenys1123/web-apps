namespace Lab3.DAL.Entities;

public class Comment : DbEntity<int>
{
    public string Text { get; set; }

    public DateTime CreateDate { get; set; }

    public int PostId { get; set; }

    public Post Post { get; set; }
}
