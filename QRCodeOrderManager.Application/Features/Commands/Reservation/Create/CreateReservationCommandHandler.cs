using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Create;

public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, CreateReservationCommandResponse>
{
    private readonly IReservationService _reservationService;
    private readonly IMapper _mapper;

    public CreateReservationCommandHandler(IReservationService reservationService, IMapper mapper)
    {
        _reservationService = reservationService;
        _mapper = mapper;
    }

    public async Task<CreateReservationCommandResponse> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        var reservation = _mapper.Map<Domain.Entities.Reservation>(request);
        await _reservationService.CreateAsync(reservation);
        return new();
    }
}