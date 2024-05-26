using System.Linq.Expressions;
using SignalR.Entity.Entities;
using SignalR.Entity.Repositories;

namespace SignalR.BusinessLayer.Repository;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(bool tracking = true);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T?> GetFirstAsync(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T?> GetByIdAsync(Guid id, bool tracking = true);
    IQueryable<T?> GetFirst(Expression<Func<T, bool>> method);
    IQueryable<T?> GetById(Guid id);
}