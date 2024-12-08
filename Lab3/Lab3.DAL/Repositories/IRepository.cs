namespace Lab3.DAL.Repositories;

public interface IRepository<TEntity, TId>
{
    Task CreateAsync(TEntity entity);

    Task<ICollection<TEntity>> GetAllAsync();

    Task<TEntity> GetByIdAsync(TId id);

    Task DeleteByIdAsync(TId entity);

    void Update(TEntity entity);

    Task SaveChangesAsync();
}
