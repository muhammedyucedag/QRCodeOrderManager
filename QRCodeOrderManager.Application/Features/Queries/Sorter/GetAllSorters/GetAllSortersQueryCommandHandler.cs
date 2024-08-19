using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Sorter;
using QRCodeOrderManager.Application.Exceptions.Sorter;

namespace QRCodeOrderManager.Application.Features.Queries.Sorter.GetAllSorters;

public class GetAllSortersQueryCommandHandler(ISorterService sorterService, IMapper mapper) : IRequestHandler<GetAllSortersQueryCommand, SorterDto[]>
{
    public async Task<SorterDto[]> Handle(GetAllSortersQueryCommand request, CancellationToken cancellationToken)
    {
        var sorters = await sorterService.GetListAllAsync();
        if (sorters is null)
            throw new NotFoundSorterException();

        var sortersDto = mapper.Map<SorterDto[]>(sorters);

        return sortersDto;
    }
}