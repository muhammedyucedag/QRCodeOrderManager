using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProductWithCategory;

public class GetAllProductWithCategoryCommandHandler(IProductService service, IMapper mapper) : IRequestHandler<GetAllProductWithCategoryCommand, ProductDto[]>
{
    public async Task<ProductDto[]> Handle(GetAllProductWithCategoryCommand request, CancellationToken cancellationToken)
    {
        var productsWithCategory = await service.GetProductsWithCategories();
        if (productsWithCategory is null)
            throw new NotFoundProductException();

        var productDtos = mapper.Map<ProductDto[]>(productsWithCategory);

        return productDtos;
    }
}