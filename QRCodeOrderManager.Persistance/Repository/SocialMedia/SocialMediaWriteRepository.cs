using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class SocialMediaWriteRepository : WriteRepository<SocialMedia>, ISocialMediaWriteRepository
{
    public SocialMediaWriteRepository(SignalRContext context) : base(context)
    {
    }
}