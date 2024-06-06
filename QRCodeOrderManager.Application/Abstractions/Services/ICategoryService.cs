using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface ICategoryService : IGenericService<Category>
{
    Task<Category> UpdateAsync(UpdateCategoryCommand request);
}