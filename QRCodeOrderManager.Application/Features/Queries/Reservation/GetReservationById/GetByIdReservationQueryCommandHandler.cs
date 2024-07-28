using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Reservation;
using QRCodeOrderManager.Application.Exceptions.Reservation;

namespace QRCodeOrderManager.Application.Features.Queries.Reservation.GetReservationById;

public class GetByIdReservationQueryCommandHandler : IRequestHandler<GetByIdReservationQueryCommand, ReservationDto>
{
    private readonly IReservationService _reservationService;
    private readonly IMapper _mapper;

    public GetByIdReservationQueryCommandHandler(IReservationService reservationService, IMapper mapper)
    {
        _reservationService = reservationService;
        _mapper = mapper;
    }

    public async Task<ReservationDto> Handle(GetByIdReservationQueryCommand request, CancellationToken cancellationToken)
    {
        var reservation = await _reservationService.GetByIdAsync(request.ReservationId);
        if (reservation is null)
            throw new NotFoundReservationException();

        return _mapper.Map<ReservationDto>(reservation);
    }
}