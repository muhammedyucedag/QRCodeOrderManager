using MediatR;
using QRCodeOrderManager.Application.DTOs.Discount;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;

public record GetAllDiscountQueryCommand : IRequest<DiscountDto[]>
{
}