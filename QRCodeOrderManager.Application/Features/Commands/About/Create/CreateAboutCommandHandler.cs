using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Create;

public record CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand, CreateAboutCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public CreateAboutCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
    {
        var about = _mapper.Map<Domain.Entities.About>(request);
        await _aboutService.CreateAsync(about);
        return new();
    }
}