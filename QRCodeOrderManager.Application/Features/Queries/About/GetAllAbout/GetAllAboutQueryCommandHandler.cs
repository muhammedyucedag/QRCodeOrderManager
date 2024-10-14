using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Exceptions.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAllAbout;

public record GetAllAboutQueryCommandHandler(IMapper Mapper, IAboutService AboutService) : IRequestHandler<GetAllAboutQueryCommand, AboutDto[]>
{
    public async Task<AboutDto[]> Handle(GetAllAboutQueryCommand request, CancellationToken cancellationToken)
    {
        var abouts = await AboutService.GetListAllAsync();
        if (abouts is null)
            throw new NotFoundAboutException();
        
        var aboutsDtos = Mapper.Map<AboutDto[]>(abouts);

        return aboutsDtos;
    }
}