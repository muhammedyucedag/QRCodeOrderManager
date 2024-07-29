using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;

public class DeleteSocialMediaCommand : IRequest<DeleteSocialMediaCommandResponse>
{
    public Guid SocialMediaId { get; set; }
}