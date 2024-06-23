using QRCodeOrderManager.Application.Features.Commands.Discount.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface IDiscountService : IGenericService<Discount>
{
    Task<Discount> UpdateAsync(UpdateDiscountCommand command);

}