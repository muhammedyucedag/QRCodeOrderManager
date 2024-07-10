using MediatR;
using QRCodeOrderManager.Application.DTOs.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProduct;

public class GetAllProductQueryCommand : IRequest<ProductDto[]>
{
    
}