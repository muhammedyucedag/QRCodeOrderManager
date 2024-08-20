using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Create;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Delete;
using QRCodeOrderManager.Application.Features.Commands.SocialMedia.Update;
using QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetAllSocialMedia;
using QRCodeOrderManager.Application.Features.Queries.SocialMedia.GetSocialMediaById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers;

[Route("api/socialmedias")]
[ApiController]
public class SocialMediaController(IMediator mediator) : BaseController(mediator)
{
    /// <summary>
    /// Sosyal medya oluşturmak için bu uç kullanılır.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Sosyal medya silmek için bu uç kullanılır.
    /// </summary>
    [HttpDelete("{SocialMediaId}")]
    public async Task<IActionResult> DeleteSocialMedia([FromRoute] DeleteSocialMediaCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Sosyal medya güncellemek için bu uç kullanılır.
    /// </summary>
    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Sosyal medya bilgilerini getirmek için bu uç kullanılır.
    /// </summary>
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllSocialMedia([FromQuery] GetAllSocialMediaQueryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Kimlik bazlı Sosyal medya getirmek için bu uç kullanılır.
    /// </summary>
    [HttpGet("{SocialMediaId}")]
    public async Task<IActionResult> GetByIdSocialMedia([FromRoute] GetByIdSocialMediaQueryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
}