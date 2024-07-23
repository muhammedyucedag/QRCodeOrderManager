using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Delete;

public class DeleteDiscountCommandHandler : IRequestHandler<DeleteDiscountCommand, DeleteDiscountCommandResponse>
{
    private readonly IDiscountService _discountService;
    
    public DeleteDiscountCommandHandler(IDiscountService discountService)
    {
        _discountService = discountService;
    }
    
    public async Task<DeleteDiscountCommandResponse> Handle(DeleteDiscountCommand request, CancellationToken cancellationToken)
    {
        await _discountService.DeleteAsync(request.DiscountId);
        return new();
    }
}
