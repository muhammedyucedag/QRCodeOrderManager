using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
{
    public CategoryReadRepository(SignalRContext context) : base(context)
    {
    }
}