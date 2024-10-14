using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;

public record UpdateSocialMediaCommand : IRequest<UpdateSocialMediaCommandResponse>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
