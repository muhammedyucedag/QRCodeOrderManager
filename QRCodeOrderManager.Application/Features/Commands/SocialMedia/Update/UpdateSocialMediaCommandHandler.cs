using MediatR;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;

public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
{
    public Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}