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
        /// Hakkında oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Kimlik bazlı hakkında bilgisini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{AboutId}")]
        public async Task<IActionResult> GetByIdAbout([FromRoute] GetByIdAboutQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Hakkında bilgisini silmek için bu uç kullanılır.
        /// </summary>
        [HttpDelete("{AboutId}")]
        public async Task<IActionResult> DeleteAbout([FromRoute] DeleteAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Gakkında bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAbout([FromQuery] GetAllAboutQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Tüm hakkında bilgisini güncellemek için bu uç kullanılır.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}