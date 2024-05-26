using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Repositories;

public class AboutRepository : GenericRepository<About>, IAboutRepository
{
    public AboutRepository(SignalRContext signalRContext) : base(signalRContext)
    {
    }
}