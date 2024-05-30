using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.About;

public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
{
    public Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}