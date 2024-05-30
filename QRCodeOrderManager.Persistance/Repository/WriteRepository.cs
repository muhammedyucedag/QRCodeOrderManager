using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly SignalRContext _context;

    public WriteRepository(SignalRContext context)
    {
        _context = context;
    }

    //EntityEntry, Entity Framework Core tarafından sağlanan bir sınıftır ve bir varlık örneğinin veri tabanındaki
    //durumunu takip eder ve bu durumu yönetir.

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> datas)
    {
        await Table.AddRangeAsync(datas);
        return true;
    }

    public async Task<bool> RemoveAsync(Guid id)
    {
        T? entity = await Table.FindAsync(id);

        if (entity == null)
        {
            return false;
        }

        EntityEntry<T> entityEntry = Table.Remove(entity);
        return entityEntry.State == EntityState.Deleted;
    }

    public bool RemoveRange(List<T> datas)
    {
        Table.RemoveRange(datas);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;
    }

    public bool Update(T model)
    {
        EntityEntry<T> entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }

    public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
}