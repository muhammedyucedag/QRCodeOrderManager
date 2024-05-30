using MediatR;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Update;

public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
{
    public Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}