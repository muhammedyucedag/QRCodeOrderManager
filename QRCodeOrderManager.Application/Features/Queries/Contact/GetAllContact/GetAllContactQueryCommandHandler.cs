using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Contact;
using QRCodeOrderManager.Application.Exceptions.Contact;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetAllContact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetAllCategory;

public class GetAllContactQueryCommandHandler : IRequestHandler<GetAllContactQueryCommand, ContactDto[]>
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public GetAllContactQueryCommandHandler(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    public async Task<ContactDto[]> Handle(GetAllContactQueryCommand request, CancellationToken cancellationToken)
    {
        var contacts = await _contactService.GetListAllAsync();
        if (contacts is null)
            throw new NotFoundContactException();

        var categoryDto = _mapper.Map<ContactDto[]>(contacts);

        return categoryDto;
    }
}