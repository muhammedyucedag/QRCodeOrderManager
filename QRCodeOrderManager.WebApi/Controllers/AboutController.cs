using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.About.Create;
using QRCodeOrderManager.Application.Features.Queries.About.GetAboutById;
using QRCodeOrderManager.Application.Features.Queries.About.GetAllAbout;
using SignalR.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : BaseController
    {
        public AboutController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAbout(Guid id)
        {
            var response = await Mediator.Send(new GetByIdAboutQueryCommand { Id = id });
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAbout([FromQuery] GetAllAboutQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}