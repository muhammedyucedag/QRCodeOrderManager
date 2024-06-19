using MediatR;
using QRCodeOrderManager.Application.DTOs.Discount;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;

public class GetDiscountByIdQueryCommandHandler : IRequestHandler<GetDiscountByIdQueryCommand, DiscountDto>
{
    public Task<DiscountDto> Handle(GetDiscountByIdQueryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}