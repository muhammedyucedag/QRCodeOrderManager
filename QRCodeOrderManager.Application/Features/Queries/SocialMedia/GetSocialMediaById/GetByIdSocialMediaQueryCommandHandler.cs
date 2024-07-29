using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;


namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetSocialMediaById;

public class GetByIdReservationQueryCommandHandler : IRequestHandler<GetByIdSocialMediaQueryCommand, SocialMediaDto>
{
    private readonly ISocialMediaService _socialMediaService;
    private readonly IMapper _mapper;

    public GetByIdReservationQueryCommandHandler(ISocialMediaService socialMediaService, IMapper mapper)
    {
        _socialMediaService = socialMediaService;
        _mapper = mapper;
    }

    public async Task<SocialMediaDto> Handle(GetByIdSocialMediaQueryCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = await _socialMediaService.GetByIdAsync(request.SocialMediaId);
        if (socialMedia is null)
            throw new NotFoundSocialMediaException();

        return _mapper.Map<SocialMediaDto>(socialMedia);
    }
}