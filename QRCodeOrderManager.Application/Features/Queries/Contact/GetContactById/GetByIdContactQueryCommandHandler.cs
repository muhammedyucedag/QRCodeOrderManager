using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Contact;
using QRCodeOrderManager.Application.Exceptions.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetContactById;

public record GetByIdContactQueryCommandHandler(IContactService ContactService, IMapper Mapper) : IRequestHandler<GetByIdContactQueryCommand, ContactDto>
{
    public async Task<ContactDto> Handle(GetByIdContactQueryCommand request, CancellationToken cancellationToken)
    {
        var contact = await ContactService.GetByIdAsync(request.ContactId);
        if (contact is null)
            throw new NotFoundContactException();

        return Mapper.Map<ContactDto>(contact);
    }
}