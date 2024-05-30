using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SocialMediaReadRepository : ReadRepository<SocialMedia>, ISocialMediaReadRepository
{
    public SocialMediaReadRepository(SignalRContext context) : base(context)
    {
    }
}