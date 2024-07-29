using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Create;


public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand, CreateSocialMediaCommandResponse>
{
    private readonly ISocialMediaService _socialMediaService;
    private readonly IMapper _mapper;

    public CreateSocialMediaCommandHandler(ISocialMediaService socialMediaService, IMapper mapper)
    {
        _socialMediaService = socialMediaService;
        _mapper = mapper;
    }

    public async Task<CreateSocialMediaCommandResponse> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = _mapper.Map<Domain.Entities.SocialMedia>(request);
        await _socialMediaService.CreateAsync(socialMedia);
        return new();
    }
}