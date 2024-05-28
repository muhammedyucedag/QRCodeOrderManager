using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class DiscountReadRepository : ReadRepository<Discount>, IDiscountReadRepository
{
    public DiscountReadRepository(SignalRContext context) : base(context)
    {
    }
}