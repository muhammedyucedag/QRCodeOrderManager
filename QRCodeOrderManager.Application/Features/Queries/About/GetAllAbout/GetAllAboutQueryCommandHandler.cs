using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Exceptions.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAllAbout;

public class GetAllAboutQueryCommandHandler : IRequestHandler<GetAllAboutQueryCommand, AboutDto[]>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public GetAllAboutQueryCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<AboutDto[]> Handle(GetAllAboutQueryCommand request, CancellationToken cancellationToken)
    {
        var abouts = await _aboutService.GetListAllAsync();
        if (abouts is null)
            throw new NotFoundAboutException();
        
        var aboutsDtos = _mapper.Map<AboutDto[]>(abouts);

        return aboutsDtos;
    }
}