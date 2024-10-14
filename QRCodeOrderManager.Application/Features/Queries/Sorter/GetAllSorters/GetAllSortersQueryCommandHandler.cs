using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Sorter;
using QRCodeOrderManager.Application.Exceptions.Sorter;

namespace QRCodeOrderManager.Application.Features.Queries.Sorter.GetAllSorters;

public record GetAllSortersQueryCommandHandler(ISorterService SorterService, IMapper Mapper) : IRequestHandler<GetAllSortersQueryCommand, SorterDto[]>
{
    public async Task<SorterDto[]> Handle(GetAllSortersQueryCommand request, CancellationToken cancellationToken)
    {
        var sorters = await SorterService.GetListAllAsync();
        if (sorters is null)
            throw new NotFoundSorterException();

        var sortersDto = Mapper.Map<SorterDto[]>(sorters);

        return sortersDto;
    }
}