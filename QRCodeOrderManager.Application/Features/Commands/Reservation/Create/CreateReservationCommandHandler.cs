using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Create;

public class CreateReservationCommandHandler(IReservationService reservationService, IMapper mapper) : IRequestHandler<CreateReservationCommand, CreateReservationCommandResponse>
{
    public async Task<CreateReservationCommandResponse> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        var reservation = mapper.Map<Domain.Entities.Reservation>(request);
        await reservationService.CreateAsync(reservation);
        return new();
    }
}