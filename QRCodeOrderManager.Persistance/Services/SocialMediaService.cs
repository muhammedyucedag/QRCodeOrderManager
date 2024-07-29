using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class SocialMediaService : ISocialMediaService
{
    private readonly ISocialMediaReadRepository _socialMediaReadRepository;
    private readonly ISocialMediaWriteRepository _socialMediaWriteRepository;
    private readonly IMapper _mapper;

    public SocialMediaService(ISocialMediaReadRepository socialMediaReadRepository, ISocialMediaWriteRepository socialMediaWriteRepository, IMapper mapper)
    {
        _socialMediaReadRepository = socialMediaReadRepository;
        _socialMediaWriteRepository = socialMediaWriteRepository;
        _mapper = mapper;
    }

    public async Task<SocialMedia> CreateAsync(SocialMedia entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = _socialMediaWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateSocialMediaFailedException();

        await _socialMediaWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<SocialMedia> UpdateAsync(UpdateSocialMediaCommand command)
    {
        var socialMedia = await _socialMediaReadRepository.GetByIdAsync(command.Id);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        socialMedia.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(command, socialMedia);

        var result = _socialMediaWriteRepository.Update(socialMedia);
        if (!result)
            throw new UpdateSocialMediaFailedException();

        await _socialMediaWriteRepository.SaveAsync();

        return socialMedia;
    }  

    public async Task DeleteAsync(Guid id)
    {
        var socialMedia = await _socialMediaReadRepository.GetByIdAsync(id);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        await _socialMediaWriteRepository.RemoveAsync(id);
        
        await _socialMediaWriteRepository.SaveAsync();
    }

    public async Task<SocialMedia?> GetByIdAsync(Guid id)
    {
        var socialMedia = await _socialMediaReadRepository.GetByIdAsync(id);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        return socialMedia;
    }

    public async Task<List<SocialMedia>> GetListAllAsync()
    {
        var socialMedias = await _socialMediaReadRepository.GetAllAsync();
        if (socialMedias is null)
            throw new NotFoundSocialMediaException();

        return socialMedias;
    }
}