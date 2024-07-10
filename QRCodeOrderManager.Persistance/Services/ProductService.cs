using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Product;
using QRCodeOrderManager.Application.Features.Commands.Product.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ProductService : IProductService
{
    private readonly IProductReadRepository _productReadRepository;
    private readonly IProductWriteRepository _productWriteRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IMapper mapper)
    {
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
        _mapper = mapper;
    }

    public async Task<Product> CreateAsync(Product entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = _productWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateProductFailedException();

        await _productWriteRepository.SaveAsync();

        return entity;
    }

    public Task<Product> UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Product?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(UpdateProductCommand command)
    {
        throw new NotImplementedException();
    }
}