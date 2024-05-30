using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SorterReadRepository : ReadRepository<Sorter>, ISorterReadRepository
{
    public SorterReadRepository(SignalRContext context) : base(context)
    {
    }
}