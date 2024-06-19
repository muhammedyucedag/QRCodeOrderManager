using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Update;

public class UpdateDiscountCommand : IRequest<UpdateDiscountCommandResponse>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}