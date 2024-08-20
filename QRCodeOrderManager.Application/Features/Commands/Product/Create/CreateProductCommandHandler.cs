using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Common;
using QRCodeOrderManager.Application.Exceptions.Category;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Create;

public class CreateProductCommandHandler(IProductService productService, ISignalRContext context, IMapper mapper) : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
{
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Domain.Entities.Product>(request);
        var category = context.Categories.Any(c => c.Id == product.CategoryId);
        if (!category)
            throw new NotFoundCategoryException();
        
        await productService.CreateAsync(product);
        return new();
    }
}