using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Create;

public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, CreateDiscountCommandResponse>
{
    private readonly IDiscountService _discountService;
    private readonly IMapper _mapper;

    public CreateDiscountCommandHandler(IDiscountService discountService, IMapper mapper)
    {
        _discountService = discountService;
        _mapper = mapper;
    }

    public async Task<CreateDiscountCommandResponse> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
    {
        var discount = _mapper.Map<Domain.Entities.Discount>(request);
        await _discountService.CreateAsync(discount);
        return new();
    }
}