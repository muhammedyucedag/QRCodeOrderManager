using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.About;
using QRCodeOrderManager.Application.Features.Commands.About.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class AboutService : IAboutService
{
    private readonly IAboutReadRepository _aboutReadRepository;
    private readonly IAboutWriteRepository _aboutWriteRepository;
    private readonly IMapper _mapper;

    public AboutService(IAboutReadRepository aboutReadRepository, IAboutWriteRepository aboutWriteRepository,
        IMapper mapper)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _mapper = mapper;
        _aboutReadRepository = aboutReadRepository;
    }

    public async Task<About> CreateAsync(About entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = await _aboutWriteRepository.AddAsync(entity);

        if (!result)
            throw new CreateAboutFailedException();

        await _aboutWriteRepository.SaveAsync();

        return entity;
    }

    public Task<About> UpdateAsync(About entity)
    {
        throw new NotImplementedException();
    }

    public async Task<About> UpdateAsync(UpdateAboutCommand request)
    {
        var about = await _aboutReadRepository.GetByIdAsync(request.Id);
        if (about == null)
            throw new NotFoundAboutException();

        about.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(request, about);

        var result = _aboutWriteRepository.Update(about);
        if (!result)
            throw new UpdateAboutFailedException();

        await _aboutWriteRepository.SaveAsync();

        return about;
    }

    public async Task DeleteAsync(Guid id)
    {
        var about = await _aboutReadRepository.GetByIdAsync(id);
        if (about is null)
            throw new NotFoundAboutException();

        await _aboutWriteRepository.RemoveAsync(id);

        await _aboutWriteRepository.SaveAsync();
    }

    public async Task<About?> GetByIdAsync(Guid id)
    {
        var about = await _aboutReadRepository.GetByIdAsync(id);
        if (about is null)
            throw new NotFoundAboutException();

        return about;
    }

    public async Task<List<About>> GetListAllAsync()
    {
        var abouts = await _aboutReadRepository.GetAllAsync();
        if (abouts is null)
            throw new NotFoundAboutException();

        return abouts;
    }
}