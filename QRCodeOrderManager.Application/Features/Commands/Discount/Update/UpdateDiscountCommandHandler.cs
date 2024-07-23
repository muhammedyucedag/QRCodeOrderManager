using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Update;

public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, UpdateDiscountCommandResponse>
{
    private readonly IDiscountService _discountService;

    public UpdateDiscountCommandHandler(IDiscountService discountService)
    {
        _discountService = discountService;
    }
    
    public async Task<UpdateDiscountCommandResponse> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
    {
        await _discountService.UpdateAsync(request);
        return new();
    }
}
