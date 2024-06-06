using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Category;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Abstract;

namespace QRCodeOrderManager.Persistance.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly ICategoryWriteRepository _categoryWriteRepository;

    public CategoryService(ICategoryWriteRepository categoryWriteRepository,
        ICategoryReadRepository categoryReadRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _categoryReadRepository = categoryReadRepository;
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

    public Task<Category> UpdateAsync(Category entity)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateAsync(UpdateCategoryCommand request)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        var category = await _categoryReadRepository.GetByIdAsync(id);
        if (category is null)
            throw new NotFoundCategoryException();

        await _categoryWriteRepository.RemoveAsync(id);

        await _categoryWriteRepository.SaveAsync();
    }

    public Task<Category?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}