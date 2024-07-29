using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;

public class DeleteReservationCommand : IRequest<DeleteReservationCommandResponse>
{
    public Guid ReservationId { get; set; }
}