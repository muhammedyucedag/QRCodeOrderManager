using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;


namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetSocialMediaById;

public record GetByIdReservationQueryCommandHandler(ISocialMediaService SocialMediaService, IMapper Mapper) : IRequestHandler<GetByIdSocialMediaQueryCommand, SocialMediaDto>
{
    public async Task<SocialMediaDto> Handle(GetByIdSocialMediaQueryCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = await SocialMediaService.GetByIdAsync(request.SocialMediaId);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        return Mapper.Map<SocialMediaDto>(socialMedia);
    }
}