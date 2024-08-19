using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Sorter;
using QRCodeOrderManager.Application.Features.Commands.Sorter.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class SorterService(ISorterReadRepository sorterReadRepository, ISorterWriteRepository sorterWriteRepository, IMapper mapper) : ISorterService
{
    public async Task<Sorter> CreateAsync(Sorter entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = sorterWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateSorterFailedException();

        await sorterWriteRepository.SaveAsync();
        return entity;
    }

    public async Task DeleteAsync(Guid id)
    {
        var sorter = await sorterReadRepository.GetByIdAsync(id);
        if (sorter is null)
            throw new NotFoundSorterException();

        await sorterWriteRepository.RemoveAsync(id);

        await sorterWriteRepository.SaveAsync();
    }

    public async Task<Sorter?> GetByIdAsync(Guid id)
    {
        var sorter = await sorterReadRepository.GetByIdAsync(id);
        if (sorter is null)
            throw new NotFoundSorterException();

        return sorter;
    }

    public async Task<List<Sorter>> GetListAllAsync()
    {
        var sorters = await sorterReadRepository.GetAllAsync();
        if (sorters is null)
            throw new NotFoundSorterException();

        return sorters;
    }

    public async Task<Sorter> UpdateAsync(UpdateSorterCommand command)
    {
        var sorter = await sorterReadRepository.GetByIdAsync(command.Id);
        if (sorter is null)
            throw new NotFoundSorterException();

        sorter.UpdatedDate = DateTime.UtcNow;

        mapper.Map(command, sorter);

        var result = sorterWriteRepository.Update(sorter);
        if (!result)
            throw new UpdateSorterFailedException();

        await sorterWriteRepository.SaveAsync();

        return sorter;
    }
}