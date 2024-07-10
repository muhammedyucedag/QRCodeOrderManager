using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Delete;

public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, DeleteContactCommandResponse>
{
    private readonly IContactService _contactService;
    
    public DeleteContactCommandHandler(IContactService contactService)
    {
        _contactService = contactService;
    }

    public async Task<DeleteContactCommandResponse> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
    {
        await _contactService.DeleteAsync(request.ContactId);
        return new();
    }
}