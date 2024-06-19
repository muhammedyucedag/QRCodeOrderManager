using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Delete;

public class DeleteDiscountCommandHandler : IRequestHandler<DeleteDiscountCommand, DeleteDiscountCommandResponse>
{
    public Task<DeleteDiscountCommandResponse> Handle(DeleteDiscountCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}