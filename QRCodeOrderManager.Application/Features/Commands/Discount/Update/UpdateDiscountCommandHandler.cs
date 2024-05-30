using MediatR;
using QRCodeOrderManager.Application.Features.Commands.Contact.Update;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Update;

public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand>
{
    public Task Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}