using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Category;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class CategoryService(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository, IMapper mapper) : ICategoryService
{
    public async Task<Category> CreateAsync(Category entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = await categoryWriteRepository.AddAsync(entity);

        if (!result)
            throw new CreateCategoryFailedException();

        await categoryWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<Category> UpdateAsync(UpdateCategoryCommand request)
    {
        var category = await categoryReadRepository.GetByIdAsync(request.Id);
        if (category is null)
            throw new NotFoundCategoryException();

        category.UpdatedDate = DateTime.UtcNow;

        mapper.Map(request, category);

        var result = categoryWriteRepository.Update(category);
        if (!result)
            throw new UpdateCategoryFailedException();

        await categoryWriteRepository.SaveAsync();

        return category;
    }

    public async Task DeleteAsync(Guid id)
    {
        var category = await categoryReadRepository.GetByIdAsync(id);
        if (category is null)
            throw new NotFoundCategoryException();

        await categoryWriteRepository.RemoveAsync(id);

        await categoryWriteRepository.SaveAsync();
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
        var category = await categoryReadRepository.GetByIdAsync(id);
        if (category is null)
            throw new NotFoundCategoryException();

        return category;
    }

    public async Task<List<Category>> GetListAllAsync()
    {
        var categories = await categoryReadRepository.GetAllAsync();
        if (categories is null)
            throw new NotFoundCategoryException();

        return categories;
    }
}