using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Create;

public class CreateReservationCommand : IRequest<CreateReservationCommandResponse>
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonCount { get; set; }
    public DateTime ReservationDate { get; set; }
}