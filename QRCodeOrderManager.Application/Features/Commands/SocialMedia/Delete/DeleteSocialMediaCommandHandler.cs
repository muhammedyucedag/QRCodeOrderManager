using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;

public class DeleteSocialMediaCommandHandler(ISocialMediaService socialMediaService) : IRequestHandler<DeleteSocialMediaCommand, DeleteSocialMediaCommandResponse>
{
    public async Task<DeleteSocialMediaCommandResponse> Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await socialMediaService.DeleteAsync(request.SocialMediaId);
        return new();
    }
}