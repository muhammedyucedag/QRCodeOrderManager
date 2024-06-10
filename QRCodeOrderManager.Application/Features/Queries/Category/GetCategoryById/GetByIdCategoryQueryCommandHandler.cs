using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Category;
using QRCodeOrderManager.Application.Exceptions.Category;

namespace QRCodeOrderManager.Application.Features.Queries.Category.GetCategoryById;

public class GetByIdCategoryQueryCommandHandler : IRequestHandler<GetByIdCategoryQueryCommand, GetByIdCategoryDto>
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public GetByIdCategoryQueryCommandHandler(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    public async Task<GetByIdCategoryDto> Handle(GetByIdCategoryQueryCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryService.GetByIdAsync(request.CategoryId);
        if (category is null)
            throw new NotFoundCategoryException();

        return _mapper.Map<GetByIdCategoryDto>(category);
    }
}