using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetProductById;

public record GetByIdProductQueryCommandHandler(IProductService ProductService, IMapper Mapper) : IRequestHandler<GetByIdProductQueryCommand, ProductDto>
{
    public async Task<ProductDto> Handle(GetByIdProductQueryCommand request, CancellationToken cancellationToken)
    {
        var product = await ProductService.GetByIdAsync(request.ProductId);
        if (product is null)
            throw new NotFoundProductException();

        return Mapper.Map<ProductDto>(product);
    }
}