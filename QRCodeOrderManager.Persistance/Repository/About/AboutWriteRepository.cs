using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
{
    public AboutWriteRepository(SignalRContext context) : base(context)
    {
    }
}