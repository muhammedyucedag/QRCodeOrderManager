using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Update;

public record UpdateSorterCommand : IRequest<UpdateSorterCommandResponse>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}