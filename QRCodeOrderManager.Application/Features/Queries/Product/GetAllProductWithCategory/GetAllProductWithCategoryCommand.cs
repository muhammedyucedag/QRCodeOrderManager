using MediatR;
using QRCodeOrderManager.Application.DTOs.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProductWithCategory;

public record GetAllProductWithCategoryCommand : IRequest<ProductDto[]>
{
    
}