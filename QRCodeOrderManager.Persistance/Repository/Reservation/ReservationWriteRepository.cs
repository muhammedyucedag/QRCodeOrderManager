using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ReservationWriteRepository : WriteRepository<Reservation>, IReservationWriteRepository
{
    public ReservationWriteRepository(SignalRContext context) : base(context)
    {
    }
}