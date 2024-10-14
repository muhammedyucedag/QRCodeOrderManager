using MediatR;
using QRCodeOrderManager.Application.DTOs.SocialMedia;

namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetSocialMediaById;

public record GetByIdSocialMediaQueryCommand : IRequest<SocialMediaDto>
{
    public Guid SocialMediaId { get; set; }
}