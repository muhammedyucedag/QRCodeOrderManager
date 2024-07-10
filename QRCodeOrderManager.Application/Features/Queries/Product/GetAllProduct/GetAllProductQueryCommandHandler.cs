using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetAllProduct;

public class GetAllProductQueryCommandHandler : IRequestHandler<GetAllProductQueryCommand, ProductDto[]>
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public GetAllProductQueryCommandHandler(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<ProductDto[]> Handle(GetAllProductQueryCommand request, CancellationToken cancellationToken)
    {
        var products = await _productService.GetListAllAsync();
        if (products is null)
            throw new NotFoundProductException();

        var productDtos = _mapper.Map<ProductDto[]>(products);

        return productDtos;
    }
}