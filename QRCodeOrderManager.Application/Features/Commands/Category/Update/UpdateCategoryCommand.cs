using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Update;

public record UpdateCategoryCommand : IRequest<UpdateCategoryCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}