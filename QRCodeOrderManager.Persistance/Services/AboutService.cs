using QRCodeOrderManager.Application.Exceptions.About;
using QRCodeOrderManager.Application.Features.Commands.About;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.BusinessLayer.Abstractions.Services;
using SignalR.DataAccessLayer.Abstract;

namespace SignalR.DataAccessLayer.Services;

public class AboutService : IAboutService
{
    private readonly IAboutReadRepository _aboutReadRepository;
    private readonly IAboutWriteRepository _aboutWriteRepository;

    public AboutService(IAboutReadRepository aboutReadRepository, IAboutWriteRepository aboutWriteRepository)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _aboutReadRepository = aboutReadRepository;
    }

    public async Task AddAsync(About entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.Now;

        var about = await _aboutWriteRepository.AddAsync(entity);

        if (about == null)
            throw new CreateAboutFailedException();
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
        throw new NotImplementedException();
    }

    public Task<About> UpdateAsync(UpdateAboutCommand command)
    {
        throw new NotImplementedException();
    }
}