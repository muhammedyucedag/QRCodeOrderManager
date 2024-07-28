using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Exceptions.Product;

namespace QRCodeOrderManager.Application.Features.Queries.Product.GetProductById;

public class GetByIdProductQueryCommandHandler : IRequestHandler<GetByIdProductQueryCommand, ProductDto>
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public GetByIdProductQueryCommandHandler(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    public async Task<ProductDto> Handle(GetByIdProductQueryCommand request, CancellationToken cancellationToken)
    {
        var product = await _productService.GetByIdAsync(request.ProductId);
        if (product is null)
            throw new NotFoundProductException();

        return _mapper.Map<ProductDto>(product);
    }
}