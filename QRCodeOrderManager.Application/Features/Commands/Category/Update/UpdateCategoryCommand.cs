using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Update;

public class UpdateCategoryCommand : IRequest<UpdateCategoryCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}