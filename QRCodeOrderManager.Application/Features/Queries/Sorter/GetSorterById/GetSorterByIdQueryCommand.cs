using MediatR;
using QRCodeOrderManager.Application.DTOs.Sorter;

namespace QRCodeOrderManager.Application.Features.Queries.Sorter.GetSorterById;

public class GetSorterByIdQueryCommand : IRequest<SorterDto>
{
    public Guid SorterId { get; set; }
}