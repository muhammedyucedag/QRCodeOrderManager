using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;

public record UpdateSocialMediaCommandHandler(ISocialMediaService SocialMediaService) : IRequestHandler<UpdateSocialMediaCommand, UpdateSocialMediaCommandResponse>
{
    public async Task<UpdateSocialMediaCommandResponse> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await SocialMediaService.UpdateAsync(request);
        return new();
    }
}