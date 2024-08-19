using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Sorter;
using QRCodeOrderManager.Application.Features.Commands.Sorter.Create;
using QRCodeOrderManager.Application.Features.Commands.Sorter.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class SorterMappingProfile : Profile
{
    public SorterMappingProfile()
    {
        CreateMap<Sorter, SorterDto>().ReverseMap();
        CreateMap<CreateSorterCommand, Sorter>().ReverseMap();
        CreateMap<UpdateSorterCommand, Sorter>().ReverseMap();
    }
}