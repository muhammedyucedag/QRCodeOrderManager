using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ReservationReadRepository : ReadRepository<Reservation>, IReservationReadRepository
{
    public ReservationReadRepository(SignalRContext context) : base(context)
    {
    }
}