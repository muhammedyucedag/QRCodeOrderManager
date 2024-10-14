using MediatR;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetCategoryById;

public record GetByIdCategoryQueryCommand : IRequest<CategoryDto>
{
    public Guid CategoryId { get; set; }
}