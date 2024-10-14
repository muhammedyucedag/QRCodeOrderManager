using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Create;

public record CreateSorterCommand : IRequest<CreateSorterCommandResponse>
{
    public string Title { get; set; }
    public string Description { get; set; }
}