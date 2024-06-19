using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Create;

public class CreateDiscountCommand : IRequest<CreateDiscountCommandResponse>
{
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}