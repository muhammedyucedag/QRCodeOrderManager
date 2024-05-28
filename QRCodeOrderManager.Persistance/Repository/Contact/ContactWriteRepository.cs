using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
{
    public ContactWriteRepository(SignalRContext context) : base(context)
    {
    }
}