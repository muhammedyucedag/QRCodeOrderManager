using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Category;
using QRCodeOrderManager.Application.Exceptions.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetAllCategory;

public record GetAllCategoryQueryCommandHandler(IMapper Mapper, ICategoryService CategoryService) : IRequestHandler<GetAllCategoryQueryCommand, CategoryDto[]>
{
    public async Task<CategoryDto[]> Handle(GetAllCategoryQueryCommand request, CancellationToken cancellationToken)
    {
        var categories = await CategoryService.GetListAllAsync();
        if (categories is null)
            throw new NotFoundCategoryException();
        
        var categoryDto = Mapper.Map<CategoryDto[]>(categories);

        return categoryDto;
    }
}