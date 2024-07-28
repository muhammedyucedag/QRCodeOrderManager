using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Update;


public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand, UpdateReservationCommandResponse>
{
    private readonly IReservationService _reservationService;

    public UpdateReservationCommandHandler(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    public async Task<UpdateReservationCommandResponse> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
    {
        await _reservationService.UpdateAsync(request);
        return new();
    }
}