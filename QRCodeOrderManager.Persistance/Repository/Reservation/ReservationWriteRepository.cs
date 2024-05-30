using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ReservationWriteRepository : WriteRepository<Reservation>, IReservationWriteRepository
{
    public ReservationWriteRepository(SignalRContext context) : base(context)
    {
    }
}