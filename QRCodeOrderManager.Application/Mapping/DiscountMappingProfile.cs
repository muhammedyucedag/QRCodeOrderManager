using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Discount;
using QRCodeOrderManager.Application.Features.Commands.Discount.Create;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;
using QRCodeOrderManager.Application.Features.Commands.Product.Create;
using QRCodeOrderManager.Application.Features.Commands.Product.Update;
using QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;
using QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class DiscountMappingProfile : Profile
{
    public DiscountMappingProfile()
    {
        CreateMap<CreateDiscountCommand, Discount>().ReverseMap();
        CreateMap<UpdateDiscountCommand, Discount>().ReverseMap();
        CreateMap<GetDiscountByIdQueryCommand, DiscountDto>().ReverseMap();
        CreateMap<GetAllDiscountQueryCommand, DiscountDto>().ReverseMap();
        CreateMap<Discount, DiscountDto>().ReverseMap();
    }
}