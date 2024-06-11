using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Update;

public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, UpdateContactCommandResponse>
{
    private readonly IContactService _contactService;

    public UpdateContactCommandHandler(IContactService contactService)
    {
        _contactService = contactService;
    }

    public async Task<UpdateContactCommandResponse> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        await _contactService.UpdateAsync(request);
        return new();
    }
}