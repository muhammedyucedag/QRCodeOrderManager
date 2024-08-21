using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Category;
using QRCodeOrderManager.Application.Features.Commands.Category.Create;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<CreateCategoryCommand, Category>().ReverseMap();
        CreateMap<UpdateCategoryCommand, Category>().ReverseMap();
        CreateMap<UpdateCategoryCommand, CategoryDto>().ReverseMap();
    }
}