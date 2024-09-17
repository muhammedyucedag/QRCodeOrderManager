using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Category;

namespace QRCodeOrderManager.Application.Features.Commands.Category.Create;

public class CreateCategoryCommandHandler(IMapper mapper, ICategoryService categoryService) : IRequestHandler<CreateCategoryCommand, CreateCategoryCommandResponse>
{
    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = mapper.Map<Domain.Entities.Category>(request);
        await categoryService.CreateAsync(category);
        return new();
    }
}