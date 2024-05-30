using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class AboutReadRepository : ReadRepository<About>, IAboutReadRepository
{
    public AboutReadRepository(SignalRContext context) : base(context)
    {
    }
}