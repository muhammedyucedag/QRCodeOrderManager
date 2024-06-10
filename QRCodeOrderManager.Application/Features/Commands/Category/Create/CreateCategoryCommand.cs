using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Create;

public class CreateCategoryCommand : IRequest<CreateCategoryCommandResponse>
{
    public string Name { get; set; }
    public bool Status { get; set; }
}