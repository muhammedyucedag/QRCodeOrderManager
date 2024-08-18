using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class SocialMediaService(ISocialMediaReadRepository socialMediaReadRepository, ISocialMediaWriteRepository socialMediaWriteRepository, IMapper mapper) : ISocialMediaService
{
    public async Task<SocialMedia> CreateAsync(SocialMedia entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = socialMediaWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateSocialMediaFailedException();

        await socialMediaWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<SocialMedia> UpdateAsync(UpdateSocialMediaCommand command)
    {
        var socialMedia = await socialMediaReadRepository.GetByIdAsync(command.Id);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        socialMedia.UpdatedDate = DateTime.UtcNow;

        mapper.Map(command, socialMedia);

        var result = socialMediaWriteRepository.Update(socialMedia);
        if (!result)
            throw new UpdateSocialMediaFailedException();

        await socialMediaWriteRepository.SaveAsync();

        return socialMedia;
    }  

    public async Task DeleteAsync(Guid id)
    {
        var socialMedia = await socialMediaReadRepository.GetByIdAsync(id);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        await socialMediaWriteRepository.RemoveAsync(id);
        
        await socialMediaWriteRepository.SaveAsync();
    }

    public async Task<SocialMedia?> GetByIdAsync(Guid id)
    {
        var socialMedia = await socialMediaReadRepository.GetByIdAsync(id);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        return socialMedia;
    }

    public async Task<List<SocialMedia>> GetListAllAsync()
    {
        var socialMedias = await socialMediaReadRepository.GetAllAsync();
        if (socialMedias is null)
            throw new NotFoundSocialMediaException();

        return socialMedias;
    }
}