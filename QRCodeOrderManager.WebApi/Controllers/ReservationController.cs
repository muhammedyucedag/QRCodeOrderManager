using MediatR;
using Microsoft.AspNetCore.Mvc;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Create;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;
using QRCodeOrderManager.Application.Features.Commands.Reservation.Update;
using QRCodeOrderManager.Application.Features.Queries.Reservation.GetAllReservation;
using QRCodeOrderManager.Application.Features.Queries.Reservation.GetReservationById;
using QRCodeOrderManager.Infrastructure.Base;

namespace QRCodeOrderManager.WebApi.Controllers;

[Route("api/reservations")]
[ApiController]
public class ReservationController : BaseController
{
    public ReservationController(IMediator mediator) : base(mediator)
    {
    }

    /// <summary>
    /// Rezervasyon oluşturmak için bu uç kullanılır.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Rezervasyon silmek için bu uç kullanılır.
    /// </summary>
    [HttpDelete("{ReservationId}")]
    public async Task<IActionResult> DeleteReservation([FromRoute] DeleteReservationCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Rezervasyon güncellemek için bu uç kullanılır.
    /// </summary>
    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateReservation(UpdateReservationCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Rezervasyon bilgilerini getirmek için bu uç kullanılır.
    /// </summary>
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllReservation([FromQuery] GetAllReservationQueryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Kimlik bazlı Rezervasyon getirmek için bu uç kullanılır.
    /// </summary>
    [HttpGet("{ReservationId}")]
    public async Task<IActionResult> GetByIdReservation([FromRoute] GetByIdReservationQueryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }
}