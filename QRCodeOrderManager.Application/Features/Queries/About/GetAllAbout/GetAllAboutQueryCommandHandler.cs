using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Exceptions.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAllAbout;

public class GetAllAboutQueryCommandHandler : IRequestHandler<GetAllAboutQueryCommand, GetAllAboutDto[]>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public GetAllAboutQueryCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<GetAllAboutDto[]> Handle(GetAllAboutQueryCommand request, CancellationToken cancellationToken)
    {
        var abouts = await _aboutService.GetListAllAsync();
        if (abouts is null)
            throw new NotFoundAboutException();
        
        var aboutsDtos = _mapper.Map<GetAllAboutDto[]>(abouts);

        return aboutsDtos;
    }
}