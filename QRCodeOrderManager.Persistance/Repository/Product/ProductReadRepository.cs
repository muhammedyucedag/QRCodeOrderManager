using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(SignalRContext context) : base(context)
    {
    }
}