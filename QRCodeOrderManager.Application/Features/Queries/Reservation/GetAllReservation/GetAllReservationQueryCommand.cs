using MediatR;
using QRCodeOrderManager.Application.DTOs.Reservation;

namespace QRCodeOrderManager.Application.Features.Queries.Reservation.GetAllReservation;

public record GetAllReservationQueryCommand : IRequest<ReservationDto[]>
{
}