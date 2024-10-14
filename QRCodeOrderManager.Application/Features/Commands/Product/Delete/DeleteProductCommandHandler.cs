using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Delete;

public record DeleteProductCommandHandler(IProductService ProductService) : IRequestHandler<DeleteProductCommand, DeleteProductCommandResponse>
{
    public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        await ProductService.DeleteAsync(request.ProductId);
        return new();
    }
}