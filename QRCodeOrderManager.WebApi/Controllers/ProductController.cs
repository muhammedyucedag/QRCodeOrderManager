using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Product.Create;
using QRCodeOrderManager.Application.Features.Commands.Product.Delete;
using QRCodeOrderManager.Application.Features.Commands.Product.Update;
using QRCodeOrderManager.Application.Features.Queries.Product.GetAllProduct;
using QRCodeOrderManager.Application.Features.Queries.Product.GetProductById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : BaseController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }
        
        /// <summary>
        /// Ürün oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateProductCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Ürün silmek için bu uç kullanılır.
        /// </summary>
        [HttpDelete("{ProductId}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] DeleteProductCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Ürün güncellemek için bu uç kullanılır.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Ürün bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllProduct([FromQuery] GetAllProductQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }

        /// <summary>
        /// Kimlik bazlı Ürün getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{ProductId}")]
        public async Task<IActionResult> GetByIdProduct([FromRoute] GetByIdProductQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
