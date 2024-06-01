using AutoMapper;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Features.Commands.About.Create;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class AboutMappingProfile : Profile
{
    public AboutMappingProfile()
    {
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<CreateAboutCommand, About>().ReverseMap();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, GetByIdAboutDto>().ReverseMap();
    }
}