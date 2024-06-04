using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Update;

public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand, UpdateAboutDto>
{
    private readonly IAboutService _aboutService;

    public UpdateAboutCommandHandler(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public async Task<UpdateAboutDto> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
    {
        await _aboutService.UpdateAsync(request);
        return new(request.Id);
    }
}