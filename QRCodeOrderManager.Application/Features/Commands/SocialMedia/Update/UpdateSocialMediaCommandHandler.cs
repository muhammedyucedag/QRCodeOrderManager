using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;

public class UpdateSocialMediaCommandHandler(ISocialMediaService socialMediaService) : IRequestHandler<UpdateSocialMediaCommand, UpdateSocialMediaCommandResponse>
{
    public async Task<UpdateSocialMediaCommandResponse> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await socialMediaService.UpdateAsync(request);
        return new();
    }
}