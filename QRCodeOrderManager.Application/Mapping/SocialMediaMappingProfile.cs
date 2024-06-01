using AutoMapper;
using QRCodeOrderManager.Application.DTOs.SocialMedia;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class SocialMediaMappingProfile : Profile
{
    public SocialMediaMappingProfile()
    {
        CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
    }
}