using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;

public record DeleteSocialMediaCommand : IRequest<DeleteSocialMediaCommandResponse>
{
    public Guid SocialMediaId { get; set; }
}