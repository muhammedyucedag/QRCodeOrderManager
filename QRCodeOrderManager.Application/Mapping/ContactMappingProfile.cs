using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Contact;
using QRCodeOrderManager.Application.Features.Commands.Contact.Create;
using QRCodeOrderManager.Application.Features.Commands.Contact.Update;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetAllContact;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetContactById;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class ContactMappingProfile : Profile
{
    public ContactMappingProfile()
    {
        CreateMap<CreateContactCommand, Contact>().ReverseMap();
        CreateMap<UpdateContactCommand, Contact>().ReverseMap();
        CreateMap<GetByIdContactQueryCommand, ContactDto>().ReverseMap();
        CreateMap<GetAllContactQueryCommand, ContactDto>().ReverseMap();
        CreateMap<Contact, ContactDto>().ReverseMap();
    }
}