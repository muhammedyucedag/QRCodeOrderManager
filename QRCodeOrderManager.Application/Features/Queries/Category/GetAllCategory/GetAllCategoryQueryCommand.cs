using MediatR;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetAllCategory;

public class GetAllCategoryQueryCommand : IRequest<CategoryDto[]>
{
}