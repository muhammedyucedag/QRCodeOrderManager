using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Discount.Create;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : BaseController
    {
        public DiscountController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateDiscountCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
