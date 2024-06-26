using AutoMapper;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Features.Commands.About.Create;
using QRCodeOrderManager.Application.Features.Commands.About.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class AboutMappingProfile : Profile
{
    public AboutMappingProfile()
    {
        CreateMap<CreateAboutCommand, About>().ReverseMap();
        CreateMap<UpdateAboutCommand, About>().ReverseMap();
        CreateMap<UpdateAboutCommand, UpdateAboutDto>().ReverseMap();
        CreateMap<About, DeleteAboutDto>();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, GetByIdAboutDto>().ReverseMap();
        CreateMap<About, GetAllAboutDto>().ReverseMap();
    }
}