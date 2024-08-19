using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;


namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetSocialMediaById;

public class GetByIdReservationQueryCommandHandler(ISocialMediaService socialMediaService, IMapper mapper) : IRequestHandler<GetByIdSocialMediaQueryCommand, SocialMediaDto>
{
    public async Task<SocialMediaDto> Handle(GetByIdSocialMediaQueryCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = await socialMediaService.GetByIdAsync(request.SocialMediaId);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        return mapper.Map<SocialMediaDto>(socialMedia);
    }
}