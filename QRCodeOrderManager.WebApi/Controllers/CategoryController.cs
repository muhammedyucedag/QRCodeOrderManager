using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Category.Create;
using QRCodeOrderManager.Application.Features.Commands.Category.Delete;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using QRCodeOrderManager.Application.Features.Queries.Category.GetAllCategory;
using QRCodeOrderManager.Application.Features.Queries.Category.GetCategoryById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoryController : BaseController
{
    public CategoryController(IMediator mediator) : base(mediator)
    {
    }

    /// <summary>
    /// Şirket oluşturmak için bu uç kullanılır.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Şirket'i silmek için bu uç kullanılır.
    /// </summary>
    [HttpDelete("{CategoryId}")]
    public async Task<IActionResult> DeleteCategory([FromRoute] DeleteCategoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Şirket'i güncellemek için bu uç kullanılır.
    /// </summary>
    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
    
    /// <summary>
    /// Şirketleri getirmek için bu uç kullanılır.
    /// </summary>
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllCategory([FromQuery] GetAllCategoryQueryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
    
    /// <summary>
    /// Kimlik bazlı şirketleri getirmek için bu uç kullanılır.
    /// </summary>
    [HttpGet("{CategoryId}")]
    public async Task<IActionResult> GetByIdCategory([FromRoute] GetByIdCategoryQueryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
}