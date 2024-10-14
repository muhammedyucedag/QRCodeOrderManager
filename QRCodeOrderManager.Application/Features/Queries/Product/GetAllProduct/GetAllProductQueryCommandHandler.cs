using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProduct;

public record GetAllProductQueryCommandHandler(IProductService ProductService, IMapper Mapper) : IRequestHandler<GetAllProductQueryCommand, ProductDto[]>
{
    public async Task<ProductDto[]> Handle(GetAllProductQueryCommand request, CancellationToken cancellationToken)
    {
        var products = await ProductService.GetListAllAsync();
        if (products is null)
            throw new NotFoundProductException();

        var productDtos = Mapper.Map<ProductDto[]>(products);

        return productDtos;
    }
}