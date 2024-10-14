using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Create;

public record CreateSorterCommandHandler(ISorterService SorterService, IMapper Mapper) : IRequestHandler<CreateSorterCommand, CreateSorterCommandResponse>
{
    public async Task<CreateSorterCommandResponse> Handle(CreateSorterCommand request, CancellationToken cancellationToken)
    {
        var sorter = Mapper.Map<Domain.Entities.Sorter>(request);
        await SorterService.CreateAsync(sorter);
        return new();
    }
}