using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SocialMediaWriteRepository : WriteRepository<SocialMedia>, ISocialMediaWriteRepository
{
    public SocialMediaWriteRepository(SignalRContext context) : base(context)
    {
    }
}