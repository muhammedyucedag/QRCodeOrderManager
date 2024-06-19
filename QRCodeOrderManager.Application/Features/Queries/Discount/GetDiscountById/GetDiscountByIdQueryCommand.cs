using MediatR;
using QRCodeOrderManager.Application.DTOs.Discount;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;

public class GetDiscountByIdQueryCommand : IRequest<DiscountDto>
{
    public Guid DiscountId { get; set; }
}