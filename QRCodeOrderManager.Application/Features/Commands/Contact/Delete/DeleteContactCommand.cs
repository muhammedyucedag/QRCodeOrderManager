using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Delete;

public record DeleteContactCommand : IRequest<DeleteContactCommandResponse>
{
    public Guid ContactId { get; set; }
}