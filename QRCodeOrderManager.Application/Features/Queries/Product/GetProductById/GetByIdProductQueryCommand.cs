using MediatR;
using QRCodeOrderManager.Application.DTOs.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetProductById;

public record GetByIdProductQueryCommand : IRequest<ProductDto>
{
    public Guid ProductId { get; set; }
}