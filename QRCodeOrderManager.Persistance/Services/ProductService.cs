using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Product;
using QRCodeOrderManager.Application.Features.Commands.Product.Update;
using QRCodeOrderManager.Application.Repository.Product;
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

        var result = await _productWriteRepository.AddAsync(entity);
        if (!result)
            throw new CreateProductFailedException();

        await _productWriteRepository.SaveAsync();

        return entity;
    }
    
    public async Task<Product> UpdateAsync(UpdateProductCommand command)
    {
        var product = await _productReadRepository.GetByIdAsync(command.Id);
        if (product is null)
            throw new NotFoundProductException();

        product.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(command, product);

        var result = _productWriteRepository.Update(product);
        if (!result)
            throw new UpdateProductFailedException();

        await _productWriteRepository.SaveAsync();

        return product;
    }

    public async Task<List<Product>> GetProductsWithCategories()
    {
        var product = await _productReadRepository.GetProductsWithCategories();
        if (product is null)
            throw new NotFoundProductException();

        return product;
    }

    public async Task DeleteAsync(Guid id)
    {
        var product = await _productReadRepository.GetByIdAsync(id);
        if (product is null)
            throw new NotFoundProductException();

        await _productWriteRepository.RemoveAsync(id);
        
        await _productWriteRepository.SaveAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        var product = await _productReadRepository.GetByIdAsync(id);
        if (product is null)
            throw new NotFoundProductException();

        return product;
    }

    public async Task<List<Product>> GetListAllAsync()
    {
        var products = await _productReadRepository.GetAllAsync();
        if (products is null)
            throw new NotFoundProductException();

        return products;
    }
         
}