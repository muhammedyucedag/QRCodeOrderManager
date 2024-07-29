using AutoMapper;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Create;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class SocialMediaMappingProfile : Profile
{
    public SocialMediaMappingProfile()
    {
        CreateMap<SocialMedia, SocialMediaDto>().ReverseMap();
        CreateMap<CreateSocialMediaCommand, SocialMedia>().ReverseMap();
        CreateMap<UpdateSocialMediaCommand, SocialMedia>().ReverseMap();
    }
}