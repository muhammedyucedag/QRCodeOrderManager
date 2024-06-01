using System.Linq.Expressions;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Repository;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T?> GetFirstAsync(Expression<Func<T, bool>> method, bool tracking = true);
    Task<T?> GetByIdAsync(Guid id, bool tracking = true);
    IQueryable<T?> GetFirst(Expression<Func<T, bool>> method);
    IQueryable<T?> GetById(Guid id);
}