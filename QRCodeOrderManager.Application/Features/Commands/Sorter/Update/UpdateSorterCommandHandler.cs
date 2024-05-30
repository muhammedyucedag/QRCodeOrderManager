using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Update;

public class UpdateSorterCommandHandler : IRequestHandler<UpdateSorterCommand>
{
    public Task Handle(UpdateSorterCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}