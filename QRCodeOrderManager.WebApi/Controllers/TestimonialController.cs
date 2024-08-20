using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Testimonial.Create;
using QRCodeOrderManager.Application.Features.Commands.Testimonial.Delete;
using QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;
using QRCodeOrderManager.Application.Features.Queries.Testimonial.GetAllTestimonials;
using QRCodeOrderManager.Application.Features.Queries.Testimonial.GetTestimonialById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/testimonials")]
    [ApiController]
    public class TestimonialController(IMediator mediator) : BaseController(mediator)
    {
        /// <summary>
        /// Referans oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Referans silmek için bu uç kullanılır.
        /// </summary>
        [HttpDelete("{TestimonialId}")]
        public async Task<IActionResult> DeleteTestimonial([FromRoute] DeleteTestimonialCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Referans güncellemek için bu uç kullanılır.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Referans bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllTestimonial([FromQuery] GetAllTestimonialsQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Referans bazlı sıralayıcı getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{TestimonialId}")]
        public async Task<IActionResult> GetByIdTestimonial([FromRoute] GetTestimonialByIdQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
