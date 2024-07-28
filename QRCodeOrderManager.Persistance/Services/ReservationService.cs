using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Reservation;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ReservationService : IReservationService
{
    private readonly IReservationReadRepository _reservationReadRepository;
    private readonly IReservationWriteRepository _reservationWriteRepository;
    private readonly IMapper _mapper;

    public ReservationService(IReservationReadRepository reservationReadRepository, IReservationWriteRepository reservationWriteRepository, IMapper mapper)
    {
        _reservationReadRepository = reservationReadRepository;
        _reservationWriteRepository = reservationWriteRepository;
        _mapper = mapper;
    }

    public async Task<Reservation> CreateAsync(Reservation entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = _reservationWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateReservationFailedException();

        await _reservationWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<Reservation> UpdateAsync(UpdateReservationCommand command)
    {
        var reservation = await _reservationReadRepository.GetByIdAsync(command.Id);
        if (reservation is null)
            throw new NotFoundReservationException();

        reservation.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(command, reservation);

        var result = _reservationWriteRepository.Update(reservation);
        if (!result)
            throw new UpdateReservationFailedException();

        await _reservationWriteRepository.SaveAsync();

        return reservation;
    }  

    public async Task DeleteAsync(Guid id)
    {
        var reservation = await _reservationReadRepository.GetByIdAsync(id);
        if (reservation is null)
            throw new NotFoundReservationException();

        await _reservationWriteRepository.RemoveAsync(id);
        
        await _reservationWriteRepository.SaveAsync();
    }

    public async Task<Reservation?> GetByIdAsync(Guid id)
    {
        var reservation = await _reservationReadRepository.GetByIdAsync(id);
        if (reservation is null)
            throw new NotFoundReservationException();

        return reservation;
    }

    public async Task<List<Reservation>> GetListAllAsync()
    {
        var reservations = await _reservationReadRepository.GetAllAsync();
        if (reservations is null)
            throw new NotFoundReservationException();

        return reservations;
    }
         
}