using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Create;

public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, CreateDiscountCommandResponse>
{
    public Task<CreateDiscountCommandResponse> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}