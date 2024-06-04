using QRCodeOrderManager.Application.Features.Commands.About.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface IAboutService : IGenericService<About>
{
    Task<About> UpdateAsync(UpdateAboutCommand request);
}