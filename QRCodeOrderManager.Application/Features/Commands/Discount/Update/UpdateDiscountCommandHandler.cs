using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Update;

public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, UpdateDiscountCommandResponse>
{
    public Task<UpdateDiscountCommandResponse> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}