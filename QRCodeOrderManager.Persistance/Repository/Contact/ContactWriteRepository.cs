using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
{
    public ContactWriteRepository(SignalRContext context) : base(context)
    {
    }
}