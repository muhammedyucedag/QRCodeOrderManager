using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;
using QRCodeOrderManager.Persistance.Repository;

namespace SignalR.DataAccessLayer.Repository;

public class DiscountWriteRepository : WriteRepository<Discount>, IDiscountWriteRepository
{
    public DiscountWriteRepository(SignalRContext context) : base(context)
    {
    }
}