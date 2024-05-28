using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class DiscountWriteRepository : WriteRepository<Discount>, IDiscountWriteRepository
{
    public DiscountWriteRepository(SignalRContext context) : base(context)
    {
    }
}