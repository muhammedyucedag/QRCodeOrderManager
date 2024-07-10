using MediatR;
using QRCodeOrderManager.Application.DTOs.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetProductById;

public class GetByIdProductQueryCommand : IRequest<ProductDto>
{
    public Guid ProductId { get; set; }
}