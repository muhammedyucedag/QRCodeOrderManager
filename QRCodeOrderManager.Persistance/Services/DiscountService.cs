using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class DiscountService : IDiscountService
{
    public Task<Discount> CreateAsync(Discount entity)
    {
        throw new NotImplementedException();
    }

    public Task<Discount> UpdateAsync(Discount entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Discount?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Discount>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}