using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Discount.Create;
using QRCodeOrderManager.Application.Features.Commands.Discount.Delete;
using QRCodeOrderManager.Application.Features.Queries.Discount.GetAllDiscount;
using QRCodeOrderManager.Application.Features.Queries.Discount.GetDiscountById;
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
        /// İndirim bilgisini oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscount(DeleteDiscountCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Tüm indirim bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllDiscount(GetAllDiscountQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Kimlik bazlı indirim bilgisini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{DiscountId}")]
        public async Task<IActionResult> GetByIdDiscount(GetDiscountByIdQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
