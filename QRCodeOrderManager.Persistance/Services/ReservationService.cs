using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ReservationService : IReservationService
{
    public Task AddAsync(Reservation entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Reservation entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Reservation>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}