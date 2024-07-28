using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface IReservationService : IGenericService<Reservation>
{
    Task<Reservation> UpdateAsync(UpdateReservationCommand command);
}