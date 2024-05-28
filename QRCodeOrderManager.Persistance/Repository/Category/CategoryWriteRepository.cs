using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(SignalRContext context) : base(context)
    {
    }
}