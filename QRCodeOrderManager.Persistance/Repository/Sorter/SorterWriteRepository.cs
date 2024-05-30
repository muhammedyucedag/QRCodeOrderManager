using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SorterWriteRepository : WriteRepository<Sorter>, ISorterWriteRepository
{
    public SorterWriteRepository(SignalRContext context) : base(context)
    {
    }
}