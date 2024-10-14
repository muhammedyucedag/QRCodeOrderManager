using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Create;

public record CreateSocialMediaCommand : IRequest<CreateSocialMediaCommandResponse>
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}