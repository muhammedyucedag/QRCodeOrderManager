using QRCodeOrderManager.Application.Features.Commands.Sorter.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface ISorterService : IGenericService<Sorter>
{
    Task<Sorter> UpdateAsync(UpdateSorterCommand command);
}