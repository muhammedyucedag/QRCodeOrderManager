using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ContactService : IContactService
{
    public Task<Contact> CreateAsync(Contact entity)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> UpdateAsync(Contact entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Contact?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Contact>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}