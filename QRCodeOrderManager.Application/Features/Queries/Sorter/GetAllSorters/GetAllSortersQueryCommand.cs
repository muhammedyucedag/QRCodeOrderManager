using MediatR;
using QRCodeOrderManager.Application.DTOs.Sorter;

namespace QRCodeOrderManager.Application.Features.Queries.Sorter.GetAllSorters;

public record GetAllSortersQueryCommand : IRequest<SorterDto[]>
{
}