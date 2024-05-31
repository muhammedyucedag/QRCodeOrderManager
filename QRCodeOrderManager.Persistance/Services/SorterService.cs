using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class SorterService : ISorterService
{
    public Task AddAsync(Sorter entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Sorter entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Sorter?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Sorter>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}