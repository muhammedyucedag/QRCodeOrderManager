using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Delete;

public class DeleteDiscountCommand : IRequest<DeleteDiscountCommandResponse>
{
    public Guid DiscountId { get; set; }
}