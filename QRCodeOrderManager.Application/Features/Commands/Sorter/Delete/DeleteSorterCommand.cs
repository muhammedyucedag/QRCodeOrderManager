using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Delete;

public record DeleteSorterCommand : IRequest<DeleteSorterCommandResponse>
{
    public Guid SorterId { get; set; }
}