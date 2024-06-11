using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Create;

public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, CreateContactCommandResponse>
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public CreateContactCommandHandler(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    public async Task<CreateContactCommandResponse> Handle(CreateContactCommand request,
        CancellationToken cancellationToken)
    {
        var contact = _mapper.Map<Domain.Entities.Contact>(request);
        await _contactService.CreateAsync(contact);
        return new();
    }
}