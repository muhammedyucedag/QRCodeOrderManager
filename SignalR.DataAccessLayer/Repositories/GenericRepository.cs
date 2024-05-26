using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly SignalRContext _signalRContext;

    public GenericRepository(SignalRContext signalRContext)
    {
        _signalRContext = signalRContext;
    }

    public async Task AddAsync(T entity)
    {
        await _signalRContext.AddAsync(entity);
        await _signalRContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _signalRContext.Remove(entity);
        await _signalRContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _signalRContext.Update(entity);
        await _signalRContext.SaveChangesAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _signalRContext.Set<T>().FindAsync(id);
    }

    public async Task<List<T>> GetListAllAsync()
    {
        return await _signalRContext.Set<T>().ToListAsync();
    }
}