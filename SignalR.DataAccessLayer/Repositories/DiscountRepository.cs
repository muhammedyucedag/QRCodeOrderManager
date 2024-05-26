using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Repositories;

public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
{
    public DiscountRepository(SignalRContext signalRContext) : base(signalRContext)
    {
    }
}