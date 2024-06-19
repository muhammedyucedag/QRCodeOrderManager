using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Contact.Create;
using QRCodeOrderManager.Application.Features.Commands.Contact.Delete;
using QRCodeOrderManager.Application.Features.Commands.Contact.Update;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetAllContact;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetContactById;
using SignalR.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : BaseController
    {
        public ContactController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{ContactId}")]
        public async Task<IActionResult> DeleteContact([FromRoute] DeleteContactCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllContact([FromQuery] GetAllContactQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{ContactId}")]
        public async Task<IActionResult> GetByIdContact([FromRoute] GetByIdContactQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}