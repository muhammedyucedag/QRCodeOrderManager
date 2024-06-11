using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Category;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryWriteRepository categoryWriteRepository,
        ICategoryReadRepository categoryReadRepository, IMapper mapper)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _categoryReadRepository = categoryReadRepository;
        _mapper = mapper;
    }

    public async Task<Category> CreateAsync(Category entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = await _categoryWriteRepository.AddAsync(entity);

        if (!result)
            throw new CreateCategoryFailedException();

        await _categoryWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<Category> UpdateAsync(UpdateCategoryCommand request)
    {
        var category = await _categoryReadRepository.GetByIdAsync(request.Id);
        if (category is null)
            throw new NotFoundCategoryException();

        category.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(request, category);

        var result = _categoryWriteRepository.Update(category);
        if (!result)
            throw new UpdateCategoryFailedException();

        await _categoryWriteRepository.SaveAsync();

        return category;
    }

    public async Task DeleteAsync(Guid id)
    {
        var category = await _categoryReadRepository.GetByIdAsync(id);
        if (category is null)
            throw new NotFoundCategoryException();

        await _categoryWriteRepository.RemoveAsync(id);

        await _categoryWriteRepository.SaveAsync();
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
        var category = await _categoryReadRepository.GetByIdAsync(id);
        if (category is null)
            throw new NotFoundCategoryException();

        return category;
    }

    public async Task<List<Category>> GetListAllAsync()
    {
        var categories = await _categoryReadRepository.GetAllAsync();
        if (categories is null)
            throw new NotFoundCategoryException();

        return categories;
    }
}