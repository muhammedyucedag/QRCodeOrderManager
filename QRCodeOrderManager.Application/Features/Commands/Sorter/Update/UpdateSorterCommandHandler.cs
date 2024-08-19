using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Update;

public class UpdateSorterCommandHandler(ISorterService sorterService) : IRequestHandler<UpdateSorterCommand, UpdateSorterCommandResponse>
{
    public async Task<UpdateSorterCommandResponse> Handle(UpdateSorterCommand request, CancellationToken cancellationToken)
    {
        await sorterService.UpdateAsync(request);
        return new();
    }
}