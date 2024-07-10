using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Discount;
using QRCodeOrderManager.Application.Exceptions.Discount;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;

public class GetAllDiscountQueryCommandHandler : IRequestHandler<GetAllDiscountQueryCommand, DiscountDto[]>
{
    private readonly IDiscountService _discountService;
    private readonly IMapper _mapper;

    public GetAllDiscountQueryCommandHandler(IDiscountService discountService, IMapper mapper)
    {
        _discountService = discountService;
        _mapper = mapper;
    }

    public async Task<DiscountDto[]> Handle(GetAllDiscountQueryCommand request, CancellationToken cancellationToken)
    {
        var discounts = await _discountService.GetListAllAsync();
        if (discounts is null)
            throw new NotFoundDiscountException();

        var discountDtos = _mapper.Map<DiscountDto[]>(discounts);

        return discountDtos;
    }
}