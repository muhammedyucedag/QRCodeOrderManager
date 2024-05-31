using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class CategoryService : ICategoryService
{
    public Task AddAsync(Category entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Category entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Category?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}