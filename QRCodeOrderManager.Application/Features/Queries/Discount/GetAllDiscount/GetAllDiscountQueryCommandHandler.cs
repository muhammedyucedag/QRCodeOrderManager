using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Discount;
using QRCodeOrderManager.Application.Exceptions.Discount;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;

public record GetAllDiscountQueryCommandHandler(IDiscountService DiscountService, IMapper Mapper) : IRequestHandler<GetAllDiscountQueryCommand, DiscountDto[]>
{
    public async Task<DiscountDto[]> Handle(GetAllDiscountQueryCommand request, CancellationToken cancellationToken)
    {
        var discounts = await DiscountService.GetListAllAsync();
        if (discounts is null)
            throw new NotFoundDiscountException();

        var discountDtos = Mapper.Map<DiscountDto[]>(discounts);

        return discountDtos;
    }
}