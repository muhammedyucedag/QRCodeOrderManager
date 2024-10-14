using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

public record UpdateReservationCommand : IRequest<UpdateReservationCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime ReservationDate { get; set; }
}