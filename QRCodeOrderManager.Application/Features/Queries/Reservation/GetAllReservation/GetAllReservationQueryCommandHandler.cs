using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Reservation;
using QRCodeOrderManager.Application.Exceptions.Reservation;

namespace QRCodeOrderManager.Application.Features.Queries.Reservation.GetAllReservation;

public class GetAllReservationQueryCommandHandler : IRequestHandler<GetAllReservationQueryCommand, ReservationDto[]>
{
    private readonly IReservationService _reservationService;
    private readonly IMapper _mapper;

    public GetAllReservationQueryCommandHandler(IReservationService reservationService, IMapper mapper)
    {
        _reservationService = reservationService;
        _mapper = mapper;
    }

    public async Task<ReservationDto[]> Handle(GetAllReservationQueryCommand request, CancellationToken cancellationToken)
    {
        var reservations = await _reservationService.GetListAllAsync();
        if (reservations is null)
            throw new NotFoundReservationException();

        var reservationDtos = _mapper.Map<ReservationDto[]>(reservations);

        return reservationDtos;
    }
}