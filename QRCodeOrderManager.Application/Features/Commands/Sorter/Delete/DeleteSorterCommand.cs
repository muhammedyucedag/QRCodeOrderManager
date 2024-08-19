using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Delete;

public class DeleteSorterCommand : IRequest<DeleteSorterCommandResponse>
{
    public Guid SorterId { get; set; }
}