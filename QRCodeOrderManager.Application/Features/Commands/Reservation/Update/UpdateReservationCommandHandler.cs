using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Update;


public record UpdateReservationCommandHandler(IReservationService ReservationService) : IRequestHandler<UpdateReservationCommand, UpdateReservationCommandResponse>
{
    public async Task<UpdateReservationCommandResponse> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
    {
        await ReservationService.UpdateAsync(request);
        return new();
    }
}