using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;

public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, DeleteReservationCommandResponse>
{
    public readonly IReservationService _reservationService;

    public DeleteReservationCommandHandler(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    public async Task<DeleteReservationCommandResponse> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
    {
        await _reservationService.DeleteAsync(request.ReservationId);
        return new();
    }
}