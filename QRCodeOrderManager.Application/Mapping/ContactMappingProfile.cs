using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Contact;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class ContactMappingProfile : Profile
{
    public ContactMappingProfile()
    {
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Contact, CreateContactDto>().ReverseMap();
        CreateMap<Contact, UpdateContactDto>().ReverseMap();
        CreateMap<Contact, GetContactDto>().ReverseMap();
    }
}