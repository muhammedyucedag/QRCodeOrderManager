using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SorterReadRepository : ReadRepository<Sorter>, ISorterReadRepository
{
    public SorterReadRepository(SignalRContext context) : base(context)
    {
    }
}