using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Delete;

public class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommand, DeleteAboutDto>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public DeleteAboutCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<DeleteAboutDto> Handle(DeleteAboutCommand request, CancellationToken cancellationToken)
    {
        await _aboutService.DeleteAsync(request.AboutId);
        return new(request.AboutId);
    }
}