using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly SignalRContext _context;

    public ReadRepository(SignalRContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = Table.AsNoTracking();
        }

        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    {
        IQueryable<T> queryable = Table;

        if (!tracking)
        {
            queryable = queryable.AsNoTracking();
        }

        var query = Table.Where(method);
        return query;
    }

    public async Task<T?> GetFirstAsync(Expression<Func<T, bool>> method, bool tracking = true)
    {
        var query = Table.AsQueryable();

        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        T? model = await query.FirstOrDefaultAsync();
        return model;
    }

    public async Task<T?> GetByIdAsync(Guid id, bool tracking = true)
    {
        var query = Table.AsQueryable();

        if (!tracking)
        {
            query = Table.AsNoTracking();
        }

        T? model = await query.FirstOrDefaultAsync(data => data.Id == id);
        return model;
    }

    public IQueryable<T?> GetFirst(Expression<Func<T, bool>> method)
    {
        var query = Table.AsQueryable();
        return query.Where(method).Take(1);
    }

    public IQueryable<T?> GetById(Guid id)
    {
        var query = Table.AsQueryable();
        var model = query.Where(data => data.Id == id);
        return model;
    }
}