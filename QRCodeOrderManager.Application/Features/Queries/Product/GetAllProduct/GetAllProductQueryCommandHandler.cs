using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProduct;

public class GetAllProductQueryCommandHandler(IProductService productService, IMapper mapper) : IRequestHandler<GetAllProductQueryCommand, ProductDto[]>
{
    public async Task<ProductDto[]> Handle(GetAllProductQueryCommand request, CancellationToken cancellationToken)
    {
        var products = await productService.GetListAllAsync();
        if (products is null)
            throw new NotFoundProductException();

        var productDtos = mapper.Map<ProductDto[]>(products);

        return productDtos;
    }
}