using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Sorter.Update;

public class UpdateSorterCommand : IRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}