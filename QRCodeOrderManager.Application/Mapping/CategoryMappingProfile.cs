using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Category;
using QRCodeOrderManager.Application.Features.Commands.Category.Create;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, ResultCategoryDto>().ReverseMap();
        CreateMap<Category, DeleteCategoryDto>();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        CreateMap<Category, GetCategoryDto>().ReverseMap();
        CreateMap<CreateCategoryCommand, Category>().ReverseMap();
    }
}