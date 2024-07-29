using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Discount.Create;
using QRCodeOrderManager.Application.Features.Commands.Discount.Delete;
using QRCodeOrderManager.Application.Features.Commands.Discount.Update;
using QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;
using QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/discount")]
    [ApiController]
    public class DiscountController : BaseController
    {
        public DiscountController(IMediator mediator) : base(mediator)
        {
        }
        
        /// <summary>
        /// İndirim bilgisini oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// İndirim bilgisini silmek için bu uç kullanılır.
        /// </summary>
        [HttpDelete("{DiscountId}")]
        public async Task<IActionResult> DeleteDiscount(DeleteDiscountCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// İndirim bilgisini güncellemek için bu uç kullanılır.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateContact(UpdateDiscountCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// İndirim bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllDiscount([FromQuery] GetAllDiscountQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Kimlik bazlı indirim bilgisini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{DiscountId}")]
        public async Task<IActionResult> GetByIdDiscount([FromRoute] GetDiscountByIdQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
