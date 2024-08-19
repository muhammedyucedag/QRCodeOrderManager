using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Delete;

public class DeleteSorterCommandHandler(ISorterService sorterService) : IRequestHandler<DeleteSorterCommand, DeleteSorterCommandResponse>
{
    public async Task<DeleteSorterCommandResponse> Handle(DeleteSorterCommand request, CancellationToken cancellationToken)
    {
        await sorterService.DeleteAsync(request.SorterId);
        return new();
    }
}