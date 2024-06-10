using MediatR;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetCategoryById;

public class GetByIdCategoryQueryCommand : IRequest<GetByIdCategoryDto>
{
    public Guid CategoryId { get; set; }
}