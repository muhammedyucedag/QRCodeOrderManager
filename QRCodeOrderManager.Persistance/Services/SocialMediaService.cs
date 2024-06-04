using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class SocialMediaService : ISocialMediaService
{
    public Task<SocialMedia> CreateAsync(SocialMedia entity)
    {
        throw new NotImplementedException();
    }

    public Task<SocialMedia> UpdateAsync(SocialMedia entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<SocialMedia?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<SocialMedia>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}