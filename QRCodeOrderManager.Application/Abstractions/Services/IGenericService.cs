namespace SignalR.BusinessLayer.Abstractions.Services;

public interface IGenericService<T> where T : class
{
    Task AddAsync(T entity);
    Task DeleteAsync(Guid id);
    Task<T?> GetByIdAsync(Guid id);
    Task<List<T>> GetListAllAsync();
}