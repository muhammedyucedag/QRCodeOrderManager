using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Delete;

public record DeleteProductCommand : IRequest<DeleteProductCommandResponse>
{
    public Guid ProductId { get; set; }
}