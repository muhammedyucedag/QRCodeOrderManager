using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Repositories;

public class SorterRepository : GenericRepository<Sorter>, ISorterRepository
{
    public SorterRepository(SignalRContext signalRContext) : base(signalRContext)
    {
    }
}