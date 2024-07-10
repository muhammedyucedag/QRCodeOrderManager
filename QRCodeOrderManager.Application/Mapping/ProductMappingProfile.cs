using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Product;
using QRCodeOrderManager.Application.Features.Commands.Product.Create;
using QRCodeOrderManager.Application.Features.Commands.Product.Update;
using QRCodeOrderManager.Application.Features.Queries.Product.GetAllProduct;
using QRCodeOrderManager.Application.Features.Queries.Product.GetProductById;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<CreateProductCommand, Product>().ReverseMap();
        CreateMap<UpdateProductCommand, Product>().ReverseMap();
        CreateMap<GetByIdProductQueryCommand, ProductDto>().ReverseMap();
        CreateMap<GetAllProductQueryCommand, ProductDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}