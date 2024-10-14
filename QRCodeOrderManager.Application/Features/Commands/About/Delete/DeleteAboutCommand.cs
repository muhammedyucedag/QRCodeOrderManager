using MediatR;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Delete;

public record DeleteAboutCommand : IRequest<DeleteAboutCommandResponse>
{
    public Guid AboutId { get; set; }
}