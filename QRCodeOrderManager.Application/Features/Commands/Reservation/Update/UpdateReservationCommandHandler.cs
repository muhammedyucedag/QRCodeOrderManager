using MediatR;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand>
{
    public Task Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}