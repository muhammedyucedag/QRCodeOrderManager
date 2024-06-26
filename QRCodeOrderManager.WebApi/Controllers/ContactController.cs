using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Contact.Create;
using QRCodeOrderManager.Application.Features.Commands.Contact.Delete;
using QRCodeOrderManager.Application.Features.Commands.Contact.Update;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetAllContact;
using QRCodeOrderManager.Application.Features.Queries.Contact.GetContactById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactController : BaseController
    {
        public ContactController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// İletişim bilgisi oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// İletişim bilgisini silmek için bu uç kullanılır.
        /// </summary>
        [HttpDelete("{ContactId}")]
        public async Task<IActionResult> DeleteContact([FromRoute] DeleteContactCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// İletişim bilgisini güncellemek için bu uç kullanılır.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// İletişim bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllContact([FromQuery] GetAllContactQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Kimlik bazlı İletişim bilgisini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{ContactId}")]
        public async Task<IActionResult> GetByIdContact([FromRoute] GetByIdContactQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}