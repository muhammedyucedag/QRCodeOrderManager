using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Category;
using QRCodeOrderManager.Application.Exceptions.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetAllCategory;

public class GetAllCategoryQueryCommandHandler : IRequestHandler<GetAllCategoryQueryCommand, GetAllCategoryDto[]>
{
    private readonly IMapper _mapper;
    private readonly ICategoryService _categoryService;

    public GetAllCategoryQueryCommandHandler(IMapper mapper, ICategoryService categoryService)
    {
        _mapper = mapper;
        _categoryService = categoryService;
    }

    public async Task<GetAllCategoryDto[]> Handle(GetAllCategoryQueryCommand request, CancellationToken cancellationToken)
    {
        var categories = await _categoryService.GetListAllAsync();
        if (categories is null)
            throw new NotFoundCategoryException();
        
        var categoryDto = _mapper.Map<GetAllCategoryDto[]>(categories);

        return categoryDto;
    }
}