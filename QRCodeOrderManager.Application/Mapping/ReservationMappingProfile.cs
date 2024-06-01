using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Reservation;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class ReservationMappingProfile : Profile
{
    public ReservationMappingProfile()
    {
        CreateMap<Reservation, ResultReservationDto>().ReverseMap();
        CreateMap<Reservation, CreateReservationDto>().ReverseMap();
        CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
        CreateMap<Reservation, GetReservationDto>().ReverseMap();
    }
}