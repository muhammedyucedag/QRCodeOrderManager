using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Exceptions.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;

public record GetByIdAboutQueryCommandHandler(IMapper Mapper, IAboutService AboutService) : IRequestHandler<GetByIdAboutQueryCommand, AboutDto>
{
    public async Task<AboutDto> Handle(GetByIdAboutQueryCommand request, CancellationToken cancellationToken)
    {
        var about = await AboutService.GetByIdAsync(request.AboutId);

        if (about is null)
            throw new NotFoundAboutException();

        return Mapper.Map<AboutDto>(about);
    }
}