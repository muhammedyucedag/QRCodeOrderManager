using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.About.Create;
using QRCodeOrderManager.Application.Features.Commands.About.Delete;
using QRCodeOrderManager.Application.Features.Commands.About.Update;
using QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;
using QRCodeOrderManager.Application.Features.Queries.About.GetAllAbout;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/abouts")]
    [ApiController]
    public class AboutController : BaseController
    {
        public AboutController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Hakkında için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{AboutId}")]
        public async Task<IActionResult> GetByIdAbout([FromRoute] GetByIdAboutQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{AboutId}")]
        public async Task<IActionResult> DeleteAbout([FromRoute] DeleteAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAbout([FromQuery] GetAllAboutQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}