using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProductWithCategory;

public record GetAllProductWithCategoryCommandHandler(IProductService ProductService, IMapper Mapper) : IRequestHandler<GetAllProductWithCategoryCommand, ProductDto[]>
{
    public async Task<ProductDto[]> Handle(GetAllProductWithCategoryCommand request, CancellationToken cancellationToken)
    {
        var productsWithCategory = await ProductService.GetProductsWithCategories();
        if (productsWithCategory is null)
            throw new NotFoundProductException();

        var productDtos = Mapper.Map<ProductDto[]>(productsWithCategory);

        return productDtos;
    }
}