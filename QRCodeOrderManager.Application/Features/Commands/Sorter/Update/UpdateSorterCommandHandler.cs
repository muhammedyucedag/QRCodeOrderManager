using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Update;

public record UpdateSorterCommandHandler(ISorterService SorterService) : IRequestHandler<UpdateSorterCommand, UpdateSorterCommandResponse>
{
    public async Task<UpdateSorterCommandResponse> Handle(UpdateSorterCommand request, CancellationToken cancellationToken)
    {
        await SorterService.UpdateAsync(request);
        return new();
    }
}