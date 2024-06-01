using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Sorter;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class SorterMappingProfile : Profile
{
    public SorterMappingProfile()
    {
        CreateMap<Sorter, ResultSorterDto>().ReverseMap();
        CreateMap<Sorter, CreateSorterDto>().ReverseMap();
        CreateMap<Sorter, UpdateSorterDto>().ReverseMap();
        CreateMap<Sorter, GetSorterDto>().ReverseMap();
    }
}