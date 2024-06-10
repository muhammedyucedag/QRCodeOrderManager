using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Category.Create;
using QRCodeOrderManager.Application.Features.Commands.Category.Delete;
using QRCodeOrderManager.Application.Features.Commands.Category.Update;
using SignalR.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : BaseController
{
    public CategoryController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateCategoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    [HttpDelete("{CategoryId}")]
    public async Task<IActionResult> DeleteAbout([FromRoute] DeleteCategoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAbout(UpdateCategoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
}