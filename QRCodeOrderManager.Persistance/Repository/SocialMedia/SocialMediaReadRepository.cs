using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SocialMediaReadRepository : ReadRepository<SocialMedia>, ISocialMediaReadRepository
{
    public SocialMediaReadRepository(SignalRContext context) : base(context)
    {
    }
}