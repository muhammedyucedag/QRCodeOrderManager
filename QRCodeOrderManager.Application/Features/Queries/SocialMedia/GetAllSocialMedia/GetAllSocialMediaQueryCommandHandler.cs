using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;

namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetAllSocialMedia;

public record GetAllSocialMediaQueryCommandHandler(ISocialMediaService SocialMediaService, IMapper Mapper) : IRequestHandler<GetAllSocialMediaQueryCommand, SocialMediaDto[]>
{
    public async Task<SocialMediaDto[]> Handle(GetAllSocialMediaQueryCommand request, CancellationToken cancellationToken)
    {
        var socialMedias = await SocialMediaService.GetListAllAsync();
        if (socialMedias is null)
            throw new NotFoundSocialMediaException();

        var socialMediaDtos = Mapper.Map<SocialMediaDto[]>(socialMedias);

        return socialMediaDtos;
    }
}