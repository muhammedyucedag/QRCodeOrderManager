using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;

public record DeleteReservationCommand : IRequest<DeleteReservationCommandResponse>
{
    public Guid ReservationId { get; set; }
}