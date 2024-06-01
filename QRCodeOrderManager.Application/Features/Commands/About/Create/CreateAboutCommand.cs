using MediatR;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Create;

public class CreateAboutCommand : IRequest<CreateAboutDto>
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}