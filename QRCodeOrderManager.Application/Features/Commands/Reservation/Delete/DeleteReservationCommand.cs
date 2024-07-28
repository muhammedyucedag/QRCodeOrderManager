using MediatR;
using QRCodeOrderManager.Application.Features.Commands.Product.Delete;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;

public class DeleteReservationCommand : IRequest<DeleteReservationCommandResponse>
{
    public Guid ReservationId { get; set; }
}