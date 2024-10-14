using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Create;

public record CreateSocialMediaCommandHandler(ISocialMediaService SocialMediaService, IMapper mapper) : IRequestHandler<CreateSocialMediaCommand, CreateSocialMediaCommandResponse>
{
    public async Task<CreateSocialMediaCommandResponse> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = mapper.Map<Domain.Entities.SocialMedia>(request);
        await SocialMediaService.CreateAsync(socialMedia);
        return new();
    }
}