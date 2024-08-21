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
        CreateMap<UpdateAboutCommand, AboutDto>().ReverseMap();
        CreateMap<About, AboutDto>().ReverseMap();
    }
}