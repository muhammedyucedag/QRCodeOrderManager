using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(SignalRContext context) : base(context)
    {
    }
}