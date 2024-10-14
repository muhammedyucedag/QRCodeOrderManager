using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Delete;

public record DeleteSorterCommandHandler(ISorterService SorterService) : IRequestHandler<DeleteSorterCommand, DeleteSorterCommandResponse>
{
    public async Task<DeleteSorterCommandResponse> Handle(DeleteSorterCommand request, CancellationToken cancellationToken)
    {
        await SorterService.DeleteAsync(request.SorterId);
        return new();
    }
}