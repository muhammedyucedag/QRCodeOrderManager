using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Sorter.Create;
using QRCodeOrderManager.Application.Features.Commands.Sorter.Delete;
using QRCodeOrderManager.Application.Features.Commands.Sorter.Update;
using QRCodeOrderManager.Application.Features.Queries.Sorter.GetAllSorters;
using QRCodeOrderManager.Application.Features.Queries.Sorter.GetSorterById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers
{
    [Route("api/sorters")]
    [ApiController]
    public class SorterController(IMediator mediator) : BaseController(mediator)
    {
        /// <summary>
        /// Sıralayıcı oluşturmak için bu uç kullanılır.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateSorter(CreateSorterCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Sıralayıcı silmek için bu uç kullanılır.
        /// </summary>
        [HttpDelete("{SorterId}")]
        public async Task<IActionResult> DeleteSorter([FromRoute] DeleteSorterCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Sıralayıcı güncellemek için bu uç kullanılır.
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateSorter(UpdateSorterCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Sıralayıcı bilgilerini getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSorter([FromQuery] GetAllSortersQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
        
        /// <summary>
        /// Kimlik bazlı sıralayıcı getirmek için bu uç kullanılır.
        /// </summary>
        [HttpGet("{SorterId}")]
        public async Task<IActionResult> GetByIdSorter([FromRoute] GetSorterByIdQueryCommand command)
        {
            var response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
