using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Sorter;
using QRCodeOrderManager.Application.Exceptions.Sorter;

namespace QRCodeOrderManager.Application.Features.Queries.Sorter.GetSorterById;

public class GetSorterByIdQueryCommandHandler(ISorterService sorterService, IMapper mapper) : IRequestHandler<GetSorterByIdQueryCommand, SorterDto>
{
    public async Task<SorterDto> Handle(GetSorterByIdQueryCommand request, CancellationToken cancellationToken)
    {
        var sorter = await sorterService.GetByIdAsync(request.SorterId);
        if (sorter is null)
            throw new NotFoundSorterException();

        return mapper.Map<SorterDto>(sorter);
    }
}