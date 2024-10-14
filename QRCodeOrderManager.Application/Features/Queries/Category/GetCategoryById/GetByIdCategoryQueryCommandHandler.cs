using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Category;
using QRCodeOrderManager.Application.Exceptions.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetCategoryById;

public record GetByIdCategoryQueryCommandHandler(ICategoryService CategoryService, IMapper Mapper) : IRequestHandler<GetByIdCategoryQueryCommand, CategoryDto>
{
    public async Task<CategoryDto> Handle(GetByIdCategoryQueryCommand request, CancellationToken cancellationToken)
    {
        var category = await CategoryService.GetByIdAsync(request.CategoryId);
        if (category is null)
            throw new NotFoundCategoryException();

        return Mapper.Map<CategoryDto>(category);
    }
}