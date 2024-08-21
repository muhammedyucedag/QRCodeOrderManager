using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Exceptions.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;

public class GetByIdAboutQueryCommandHandler : IRequestHandler<GetByIdAboutQueryCommand, AboutDto>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public GetByIdAboutQueryCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<AboutDto> Handle(GetByIdAboutQueryCommand request, CancellationToken cancellationToken)
    {
        var about = await _aboutService.GetByIdAsync(request.AboutId);

        if (about is null)
            throw new NotFoundAboutException();

        return _mapper.Map<AboutDto>(about);
    }
}