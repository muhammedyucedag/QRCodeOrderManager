using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Repositories;

public class ContactRepository : GenericRepository<Contact>, IContactRepository
{
    public ContactRepository(SignalRContext signalRContext) : base(signalRContext)
    {
    }
}