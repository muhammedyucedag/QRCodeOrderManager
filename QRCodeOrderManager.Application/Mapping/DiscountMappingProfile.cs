using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Discount;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class DiscountMappingProfile : Profile
{
    public DiscountMappingProfile()
    {
        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountDto>().ReverseMap();
    }
}