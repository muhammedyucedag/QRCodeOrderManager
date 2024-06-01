using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.About;
using QRCodeOrderManager.Application.Exceptions.About;

namespace QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;

public class GetByIdAboutCommandHandler : IRequestHandler<GetByIdAboutCommand, GetByIdAboutDto>
{
    private readonly IMapper _mapper;
    private readonly IAboutService _aboutService;

    public GetByIdAboutCommandHandler(IMapper mapper, IAboutService aboutService)
    {
        _mapper = mapper;
        _aboutService = aboutService;
    }

    public async Task<GetByIdAboutDto> Handle(GetByIdAboutCommand request, CancellationToken cancellationToken)
    {
        var about = await _aboutService.GetByIdAsync(request.Id);

        if (about == null)
        {
            throw new NotFoundAboutException();
        }

        return _mapper.Map<GetByIdAboutDto>(about);
    }
}