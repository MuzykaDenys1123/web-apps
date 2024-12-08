namespace Lab3.DAL.Entities;
public abstract class DbEntity<TId>
{
    public TId Id { get; set; }
}
