using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;

public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand, UpdateSocialMediaCommandResponse>
{
    private readonly ISocialMediaService _socialMediaService;

    public UpdateSocialMediaCommandHandler(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    public async Task<UpdateSocialMediaCommandResponse> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await _socialMediaService.UpdateAsync(request);
        return new();
    }
}