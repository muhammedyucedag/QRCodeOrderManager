using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;

public record DeleteReservationCommandHandler(IReservationService ReservationService) : IRequestHandler<DeleteReservationCommand, DeleteReservationCommandResponse>
{
    public async Task<DeleteReservationCommandResponse> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
    {
        await ReservationService.DeleteAsync(request.ReservationId);
        return new();
    }
}