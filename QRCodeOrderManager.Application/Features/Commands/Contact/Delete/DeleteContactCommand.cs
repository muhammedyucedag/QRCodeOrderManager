using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Delete;

public class DeleteContactCommand : IRequest<DeleteContactCommandResponse>
{
    public Guid ContactId { get; set; }
}