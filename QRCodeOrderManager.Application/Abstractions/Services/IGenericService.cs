namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface IGenericService<T> where T : class
{
    Task<T> CreateAsync(T entity);
    Task DeleteAsync(Guid id);
    Task<T?> GetByIdAsync(Guid id);
    Task<List<T>> GetListAllAsync();
}