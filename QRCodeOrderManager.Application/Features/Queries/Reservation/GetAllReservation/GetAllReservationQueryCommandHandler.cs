using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Reservation;
using QRCodeOrderManager.Application.Exceptions.Reservation;

namespace QRCodeOrderManager.Application.Features.Queries.Reservation.GetAllReservation;

public record GetAllReservationQueryCommandHandler(IReservationService ReservationService, IMapper Mapper) : IRequestHandler<GetAllReservationQueryCommand, ReservationDto[]>
{
    public async Task<ReservationDto[]> Handle(GetAllReservationQueryCommand request, CancellationToken cancellationToken)
    {
        var reservations = await ReservationService.GetListAllAsync();
        if (reservations is null)
            throw new NotFoundReservationException();

        var reservationDtos = Mapper.Map<ReservationDto[]>(reservations);

        return reservationDtos;
    }
}