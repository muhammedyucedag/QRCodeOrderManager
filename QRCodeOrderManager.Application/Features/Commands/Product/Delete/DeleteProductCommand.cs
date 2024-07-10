using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Delete;

public class DeleteProductCommand : IRequest<DeleteProductCommandResponse>
{
    public Guid ProductId { get; set; }
}