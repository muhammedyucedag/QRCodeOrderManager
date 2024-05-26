using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class AboutReadRepository : ReadRepository<About>, IAboutReadRepository
{
    public AboutReadRepository(SignalRContext context) : base(context)
    {
    }
}