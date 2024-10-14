using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Reservation;
using QRCodeOrderManager.Application.Exceptions.Reservation;

namespace QRCodeOrderManager.Application.Features.Queries.Reservation.GetReservationById;

public record GetByIdReservationQueryCommandHandler(IReservationService ReservationService, IMapper Mapper) : IRequestHandler<GetByIdReservationQueryCommand, ReservationDto>
{
    public async Task<ReservationDto> Handle(GetByIdReservationQueryCommand request, CancellationToken cancellationToken)
    {
        var reservation = await ReservationService.GetByIdAsync(request.ReservationId);
        if (reservation is null)
            throw new NotFoundReservationException();

        return Mapper.Map<ReservationDto>(reservation);
    }
}