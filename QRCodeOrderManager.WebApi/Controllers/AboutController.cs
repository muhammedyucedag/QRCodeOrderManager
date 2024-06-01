using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.About.Create;
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
        public async Task<IActionResult> CreateContact(CreateAboutCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}