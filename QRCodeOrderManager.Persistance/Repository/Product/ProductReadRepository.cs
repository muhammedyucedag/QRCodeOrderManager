using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(SignalRContext context) : base(context)
    {
    }
}