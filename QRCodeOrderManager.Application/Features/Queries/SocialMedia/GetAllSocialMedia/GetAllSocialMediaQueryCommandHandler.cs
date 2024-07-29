using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Application.Exceptions.SocialMedia;

namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetAllSocialMedia;

public class GetAllSocialMediaQueryCommandHandler : IRequestHandler<GetAllSocialMediaQueryCommand, SocialMediaDto[]>
{
    private readonly ISocialMediaService _socialMediaService;
    private readonly IMapper _mapper;

    public GetAllSocialMediaQueryCommandHandler(ISocialMediaService socialMediaService, IMapper mapper)
    {
        _socialMediaService = socialMediaService;
        _mapper = mapper;
    }

    public async Task<SocialMediaDto[]> Handle(GetAllSocialMediaQueryCommand request, CancellationToken cancellationToken)
    {
        var socialMedias = await _socialMediaService.GetListAllAsync();
        if (socialMedias is null)
            throw new NotFoundSocialMediaException();

        var socialMediaDtos = _mapper.Map<SocialMediaDto[]>(socialMedias);

        return socialMediaDtos;
    }
}