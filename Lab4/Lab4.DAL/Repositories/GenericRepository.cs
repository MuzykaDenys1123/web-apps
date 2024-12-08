
using Lab4.DAL.Context;
using Lab4.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab4.DAL.Repositories;

public class GenericRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : DbEntity<TId>
{
    private readonly ProgrammingBlogContext _context;

    private DbSet<TEntity> Table => _context.Set<TEntity>();

    public GenericRepository(ProgrammingBlogContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(TEntity entity)
    {
        await _context.AddAsync(entity);
    }

    public async Task<ICollection<TEntity>> GetAllAsync()
    {
        return await Table.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(TId id)
    {
        return await Table.FirstOrDefaultAsync(e => e.Id.Equals(id));
    }

    public async Task DeleteByIdAsync(TId id)
    {
        await Table.Where(e => e.Id.Equals(id)).ExecuteDeleteAsync();
    }

    public void Update(TEntity entity)
    {
        _context.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
