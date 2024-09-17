using QRCodeOrderManager.Application.Repository.Reservation;
using QRCodeOrderManager.Persistance.Concrete;
using SignalR.DataAccessLayer.Repository;

namespace QRCodeOrderManager.Persistance.Repository.Reservation;

public class ReservationWriteRepository : WriteRepository<Domain.Entities.Reservation>, IReservationWriteRepository
{
    public ReservationWriteRepository(SignalRContext context) : base(context)
    {
    }
}