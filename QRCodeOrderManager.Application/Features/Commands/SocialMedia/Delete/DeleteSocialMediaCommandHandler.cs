using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;

public class DeleteSocialMediaCommandHandler : IRequestHandler<DeleteSocialMediaCommand, DeleteSocialMediaCommandResponse>
{
    public readonly ISocialMediaService _socialMediaService;

    public DeleteSocialMediaCommandHandler(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    public async Task<DeleteSocialMediaCommandResponse> Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await _socialMediaService.DeleteAsync(request.SocialMediaId);
        return new();
    }
}