namespace QRCodeOrderManager.Application.Repository.Product;

public interface IProductReadRepository : IReadRepository<Domain.Entities.Product>
{
    Task<List<Domain.Entities.Product>>  GetProductsWithCategories();
}