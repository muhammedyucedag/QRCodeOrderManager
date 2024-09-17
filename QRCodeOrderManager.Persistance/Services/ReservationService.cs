using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Reservation;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;
using QRCodeOrderManager.Application.Repository.Reservation;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ReservationService(IReservationReadRepository reservationReadRepository, IReservationWriteRepository reservationWriteRepository, IMapper mapper) : IReservationService
{
    public async Task<Reservation> CreateAsync(Reservation entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = await reservationWriteRepository.AddAsync(entity);
        
        if (!result)
            throw new CreateReservationFailedException();

        await reservationWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<Reservation> UpdateAsync(UpdateReservationCommand command)
    {
        var reservation = await reservationReadRepository.GetByIdAsync(command.Id);
        if (reservation is null)
            throw new NotFoundReservationException();

        reservation.UpdatedDate = DateTime.UtcNow;

        mapper.Map(command, reservation);

        var result = reservationWriteRepository.Update(reservation);
        if (!result)
            throw new UpdateReservationFailedException();

        await reservationWriteRepository.SaveAsync();

        return reservation;
    }  

    public async Task DeleteAsync(Guid id)
    {
        var reservation = await reservationReadRepository.GetByIdAsync(id);
        if (reservation is null)
            throw new NotFoundReservationException();

        await reservationWriteRepository.RemoveAsync(id);
        
        await reservationWriteRepository.SaveAsync();
    }

    public async Task<Reservation?> GetByIdAsync(Guid id)
    {
        var reservation = await reservationReadRepository.GetByIdAsync(id);
        if (reservation is null)
            throw new NotFoundReservationException();

        return reservation;
    }

    public async Task<List<Reservation>> GetListAllAsync()
    {
        var reservations = await reservationReadRepository.GetAllAsync();
        if (reservations is null)
            throw new NotFoundReservationException();

        return reservations;
    }
}