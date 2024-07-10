using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Discount;
using QRCodeOrderManager.Application.Exceptions.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;

public class GetDiscountByIdQueryCommandHandler : IRequestHandler<GetDiscountByIdQueryCommand, DiscountDto>
{
    private readonly IDiscountService _discountService;
    private readonly IMapper _mapper;

    public GetDiscountByIdQueryCommandHandler(IDiscountService discountService, IMapper mapper)
    {
        _discountService = discountService;
        _mapper = mapper;
    }

    public async Task<DiscountDto> Handle(GetDiscountByIdQueryCommand request, CancellationToken cancellationToken)
    {
        var discount = await _discountService.GetByIdAsync(request.DiscountId);
        if (discount is null)
            throw new NotFoundContactException();

        return _mapper.Map<DiscountDto>(discount);
    }
}