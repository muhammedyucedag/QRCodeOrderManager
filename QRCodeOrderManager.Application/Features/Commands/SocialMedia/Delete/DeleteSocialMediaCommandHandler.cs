using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;

public record DeleteSocialMediaCommandHandler(ISocialMediaService SocialMediaService) : IRequestHandler<DeleteSocialMediaCommand, DeleteSocialMediaCommandResponse>
{
    public async Task<DeleteSocialMediaCommandResponse> Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await SocialMediaService.DeleteAsync(request.SocialMediaId);
        return new();
    }
}