using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Create;

public record CreateReservationCommandHandler(IReservationService ReservationService, IMapper Mapper) : IRequestHandler<CreateReservationCommand, CreateReservationCommandResponse>
{
    public async Task<CreateReservationCommandResponse> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        var reservation = Mapper.Map<Domain.Entities.Reservation>(request);
        await ReservationService.CreateAsync(reservation);
        return new();
    }
}