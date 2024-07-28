using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Delete;

public class DeleteReservationCommandResponse : BaseResponse
{
    public DeleteReservationCommandResponse()
    {
        Message = "Rezervasyon başarıyla silindi.";
    }
}