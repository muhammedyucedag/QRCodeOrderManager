using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.About.Update;

public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand, UpdateAboutCommandResponse>
{
    private readonly IAboutService _aboutService;

    public UpdateAboutCommandHandler(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public async Task<UpdateAboutCommandResponse> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
    {
        await _aboutService.UpdateAsync(request);
        return new();
    }
}