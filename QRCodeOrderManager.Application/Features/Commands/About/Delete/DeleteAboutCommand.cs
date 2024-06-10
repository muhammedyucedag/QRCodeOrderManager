using MediatR;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Delete;

public class DeleteAboutCommand : IRequest<DeleteAboutCommandResponse>
{
    public Guid AboutId { get; set; }
}