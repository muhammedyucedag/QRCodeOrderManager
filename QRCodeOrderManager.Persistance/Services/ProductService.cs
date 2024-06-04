using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ProductService : IProductService
{
    public Task<Product> CreateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Product?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}