using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Delete;

public record DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommand, DeleteAboutCommandResponse>
{
    private readonly IAboutService _aboutService;

    public DeleteAboutCommandHandler(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public async Task<DeleteAboutCommandResponse> Handle(DeleteAboutCommand request, CancellationToken cancellationToken)
    {
        await _aboutService.DeleteAsync(request.AboutId);
        return new();
    }
}