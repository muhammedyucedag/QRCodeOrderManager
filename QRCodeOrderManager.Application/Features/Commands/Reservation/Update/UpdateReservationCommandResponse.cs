using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Update;

public class UpdateReservationCommandResponse : BaseResponse
{
    public UpdateReservationCommandResponse()
    {
        Message = "Rezervason başarılı bir şekilde güncellendi.";
    }
}