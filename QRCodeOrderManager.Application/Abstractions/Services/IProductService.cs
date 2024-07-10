using QRCodeOrderManager.Application.Features.Commands.Product.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface IProductService : IGenericService<Product>
{
    Task<Product> UpdateAsync(UpdateProductCommand command);

}