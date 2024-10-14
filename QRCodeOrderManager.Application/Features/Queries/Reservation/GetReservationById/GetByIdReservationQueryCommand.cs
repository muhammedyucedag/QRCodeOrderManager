using MediatR;
using QRCodeOrderManager.Application.DTOs.Reservation;

namespace QRCodeOrderManager.Application.Features.Queries.Reservation.GetReservationById;

public record GetByIdReservationQueryCommand : IRequest<ReservationDto>
{
    public Guid ReservationId { get; set; }
}