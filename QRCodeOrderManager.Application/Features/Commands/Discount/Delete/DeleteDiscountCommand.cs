using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Delete;

public record DeleteDiscountCommand : IRequest<DeleteDiscountCommandResponse>
{
    public Guid DiscountId { get; set; }
}