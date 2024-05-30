using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
{
    public AboutWriteRepository(SignalRContext context) : base(context)
    {
    }
}