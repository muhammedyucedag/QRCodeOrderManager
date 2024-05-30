using MediatR;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Update;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    public Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}