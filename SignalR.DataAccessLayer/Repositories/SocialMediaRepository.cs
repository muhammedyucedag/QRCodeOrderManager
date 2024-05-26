using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Repositories;

public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
{
    public SocialMediaRepository(SignalRContext signalRContext) : base(signalRContext)
    {
    }
}