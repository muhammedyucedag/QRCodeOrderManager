using MediatR;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetAllCategory;

public record GetAllCategoryQueryCommand : IRequest<CategoryDto[]>
{
}