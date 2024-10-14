using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Contact;
using QRCodeOrderManager.Application.Exceptions.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetAllContact;

public record GetAllContactQueryCommandHandler(IContactService ContactService, IMapper Mapper) : IRequestHandler<GetAllContactQueryCommand, ContactDto[]>
{
    public async Task<ContactDto[]> Handle(GetAllContactQueryCommand request, CancellationToken cancellationToken)
    {
        var contacts = await ContactService.GetListAllAsync();
        if (contacts is null)
            throw new NotFoundContactException();

        var categoryDto = Mapper.Map<ContactDto[]>(contacts);

        return categoryDto;
    }
}