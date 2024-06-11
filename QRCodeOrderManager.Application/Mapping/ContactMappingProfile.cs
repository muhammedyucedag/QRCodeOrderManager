using AutoMapper;
using QRCodeOrderManager.Application.Features.Commands.Contact.Create;
using QRCodeOrderManager.Application.Features.Commands.Contact.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class ContactMappingProfile : Profile
{
    public ContactMappingProfile()
    {
        CreateMap<CreateContactCommand, Contact>().ReverseMap();
        CreateMap<UpdateContactCommand, Contact>().ReverseMap();
    }
}