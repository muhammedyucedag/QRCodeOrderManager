using MediatR;
using QRCodeOrderManager.Application.DTOs.SocialMedia;

namespace QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetAllSocialMedia;

public record GetAllSocialMediaQueryCommand : IRequest<SocialMediaDto[]>
{
}