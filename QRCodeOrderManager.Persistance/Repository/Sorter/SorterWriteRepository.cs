using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SorterWriteRepository : WriteRepository<Sorter>, ISorterWriteRepository
{
    public SorterWriteRepository(SignalRContext context) : base(context)
    {
    }
}