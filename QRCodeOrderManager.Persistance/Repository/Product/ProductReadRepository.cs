using Microsoft.EntityFrameworkCore;
using QRCodeOrderManager.Application.Repository.Product;
using QRCodeOrderManager.Persistance.Concrete;

namespace QRCodeOrderManager.Persistance.Repository.Product;

public class ProductReadRepository(SignalRContext context) : ReadRepository<Domain.Entities.Product>(context), IProductReadRepository
{
    public async Task<List<Domain.Entities.Product>> GetProductsWithCategories()
    {
        var values = await context.Products.Include(x => x.Category).ToListAsync();
        return values;
    }
}