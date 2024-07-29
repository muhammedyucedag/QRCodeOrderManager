using MediatR;
using QRCodeOrderManager.Application.DTOs.SocialMedia;

namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetSocialMediaById;

public class GetByIdSocialMediaQueryCommand : IRequest<SocialMediaDto>
{
    public Guid SocialMediaId { get; set; }
}