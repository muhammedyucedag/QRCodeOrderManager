using QRCodeOrderManager.Application.Features.Commands.About;
using QRCodeOrderManager.Domain.Entities;

namespace SignalR.BusinessLayer.Abstractions.Services;

public interface IAboutService : IGenericService<About>
{
    Task<About> UpdateAsync(UpdateAboutCommand command);
}