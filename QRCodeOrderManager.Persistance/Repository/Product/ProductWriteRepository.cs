using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Application.Repository.Product;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;
using QRCodeOrderManager.Persistance.Repository;

namespace SignalR.DataAccessLayer.Repository;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(SignalRContext context) : base(context)
    {
    }
}