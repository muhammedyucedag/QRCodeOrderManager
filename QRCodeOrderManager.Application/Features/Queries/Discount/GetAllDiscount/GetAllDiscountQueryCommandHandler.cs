using MediatR;
using QRCodeOrderManager.Application.DTOs.Discount;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;

public class GetAllDiscountQueryCommandHandler : IRequestHandler<GetAllDiscountQueryCommand, DiscountDto[]>
{
    public Task<DiscountDto[]> Handle(GetAllDiscountQueryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}