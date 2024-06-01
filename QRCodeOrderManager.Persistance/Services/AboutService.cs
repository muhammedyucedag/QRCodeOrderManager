using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.About;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class AboutService : IAboutService
{
    private readonly IAboutReadRepository _aboutReadRepository;
    private readonly IAboutWriteRepository _aboutWriteRepository;

    public AboutService(IAboutReadRepository aboutReadRepository, IAboutWriteRepository aboutWriteRepository)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _aboutReadRepository = aboutReadRepository;
    }

    public async Task CreateAsync(About entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        await _aboutWriteRepository.AddAsync(entity);

        var savedEntitiesCount = await _aboutWriteRepository.SaveAsync();

        if (savedEntitiesCount == 0)
        {
            throw new CreateAboutFailedException();
        }
    }

    public Task UpdateAsync(About entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        var about = await _aboutReadRepository.GetByIdAsync(id);
        if (about == null)
        {
            throw new NotFoundAboutException();
        }

        var aboutResult = await _aboutWriteRepository.RemoveAsync(id);
        if (aboutResult == null)
        {
            throw new DeleteAboutFailedException();
        }
    }

    public async Task<About?> GetByIdAsync(Guid id)
    {
        return await _aboutReadRepository.GetByIdAsync(id);
    }

    public Task<List<About>> GetListAllAsync()
    {
        return _aboutReadRepository.GetAllAsync();
    }
}