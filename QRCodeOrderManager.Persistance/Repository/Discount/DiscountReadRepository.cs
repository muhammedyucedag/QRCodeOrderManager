using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class DiscountReadRepository : ReadRepository<Discount>, IDiscountReadRepository
{
    public DiscountReadRepository(SignalRContext context) : base(context)
    {
    }
}