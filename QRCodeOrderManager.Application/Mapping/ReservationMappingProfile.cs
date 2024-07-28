using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Reservation;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Create;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class ReservationMappingProfile : Profile
{
    public ReservationMappingProfile()
    {
        CreateMap<Reservation, ReservationDto>().ReverseMap();
        CreateMap<CreateReservationCommand, Reservation>().ReverseMap();
        CreateMap<UpdateReservationCommand, Reservation>().ReverseMap();
    }
}