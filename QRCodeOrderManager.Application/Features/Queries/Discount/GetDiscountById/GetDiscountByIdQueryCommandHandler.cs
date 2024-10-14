using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Discount;
using QRCodeOrderManager.Application.Exceptions.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;

public record GetDiscountByIdQueryCommandHandler(IDiscountService DiscountService, IMapper Mapper) : IRequestHandler<GetDiscountByIdQueryCommand, DiscountDto>
{
    public async Task<DiscountDto> Handle(GetDiscountByIdQueryCommand request, CancellationToken cancellationToken)
    {
        var discount = await DiscountService.GetByIdAsync(request.DiscountId);
        if (discount is null)
            throw new NotFoundContactException();

        return Mapper.Map<DiscountDto>(discount);
    }
}