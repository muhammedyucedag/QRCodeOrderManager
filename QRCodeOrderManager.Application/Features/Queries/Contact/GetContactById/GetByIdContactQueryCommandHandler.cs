using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Contact;
using QRCodeOrderManager.Application.Exceptions.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetContactById;

public class GetByIdContactQueryCommandHandler : IRequestHandler<GetByIdContactQueryCommand, ContactDto>
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public GetByIdContactQueryCommandHandler(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    public async Task<ContactDto> Handle(GetByIdContactQueryCommand request, CancellationToken cancellationToken)
    {
        var contact = await _contactService.GetByIdAsync(request.ContactId);
        if (contact is null)
            throw new NotFoundContactException();

        return _mapper.Map<ContactDto>(contact);
    }
}