using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(SignalRContext context) : base(context)
    {
    }
}