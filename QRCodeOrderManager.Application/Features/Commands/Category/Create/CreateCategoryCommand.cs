using MediatR;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Create;

public class CreateCategoryCommand : IRequest<CreateCategoryDto>
{
    public string Name { get; set; }
    public bool Status { get; set; }
}