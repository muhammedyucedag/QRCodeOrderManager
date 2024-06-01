using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;

namespace QRCodeOrderManager.Application.Features.Commands.About.Create;

public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand, CreateAboutDto>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public CreateAboutCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<CreateAboutDto> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
    {
        var about = _mapper.Map<Domain.Entities.About>(request);
        await _aboutService.CreateAsync(about);
        var createdAboutDto = _mapper.Map<CreateAboutDto>(about);
        return createdAboutDto;
    }
}