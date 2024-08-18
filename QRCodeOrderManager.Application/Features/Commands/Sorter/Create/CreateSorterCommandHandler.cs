using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Create;

public class CreateSorterCommandHandler(ISorterService sorterService, IMapper mapper) : IRequestHandler<CreateSorterCommand, CreateSorterCommandResponse>
{
    public async Task<CreateSorterCommandResponse> Handle(CreateSorterCommand request, CancellationToken cancellationToken)
    {
        var sorter = mapper.Map<Domain.Entities.Sorter>(request);
        await sorterService.CreateAsync(sorter);
        return new();
    }
}