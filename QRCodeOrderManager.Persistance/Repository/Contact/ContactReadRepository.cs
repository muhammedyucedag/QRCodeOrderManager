using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
{
    public ContactReadRepository(SignalRContext context) : base(context)
    {
    }
}