using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Discount;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class DiscountService : IDiscountService
{
    private readonly IDiscountReadRepository _discountReadRepository;
    private readonly IDiscountWriteRepository _discountWriteRepository;
    private readonly IMapper _mapper;

    public DiscountService(IDiscountReadRepository discountReadRepository,
        IDiscountWriteRepository discountWriteRepository, IMapper mapper)
    {
        _discountReadRepository = discountReadRepository;
        _discountWriteRepository = discountWriteRepository;
        _mapper = mapper;
    }

    public async Task<Discount> CreateAsync(Discount entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = _discountWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateDiscountFailedException();

        await _discountWriteRepository.SaveAsync();

        return entity;
    }

    public async Task<Discount> UpdateAsync(UpdateDiscountCommand command)
    {
        var discount = await _discountReadRepository.GetByIdAsync(command.Id);
        if (discount is null)
            throw new NotFoundDiscountException();

        discount.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(command, discount);

        var result = _discountWriteRepository.Update(discount);
        if (!result)
            throw new UpdateDiscountFailedException();

        await _discountWriteRepository.SaveAsync();

        return discount;
    }

    public async Task DeleteAsync(Guid id)
    {
        var discount = await _discountReadRepository.GetByIdAsync(id);
        if (discount is null)
            throw new NotFoundDiscountException();

        await _discountWriteRepository.RemoveAsync(id);

        await _discountWriteRepository.SaveAsync();
    }

    public async Task<Discount?> GetByIdAsync(Guid id)
    {
        var discount = await _discountReadRepository.GetByIdAsync(id);
        if (discount is null)
            throw new NotFoundDiscountException();

        return discount;
    }

    public async Task<List<Discount>> GetListAllAsync()
    {
        var discounts = await _discountReadRepository.GetAllAsync();
        if (discounts is null)
            throw new NotFoundDiscountException();

        return discounts;
    }
}