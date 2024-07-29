using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface ISocialMediaService : IGenericService<SocialMedia>
{
    Task<SocialMedia> UpdateAsync(UpdateSocialMediaCommand command);
}