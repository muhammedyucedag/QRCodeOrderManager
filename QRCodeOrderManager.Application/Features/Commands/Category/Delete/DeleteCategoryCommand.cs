using MediatR;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Delete;

public class DeleteCategoryCommand : IRequest<DeleteCategoryCommandRespone>
{
    public Guid CategoryId { get; set; }
}