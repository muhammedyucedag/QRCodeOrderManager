using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
{
    public ContactReadRepository(SignalRContext context) : base(context)
    {
    }
}