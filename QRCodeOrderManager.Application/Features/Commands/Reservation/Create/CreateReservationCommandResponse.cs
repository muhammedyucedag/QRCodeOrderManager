using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Reservation.Create;

public class CreateReservationCommandResponse : BaseResponse
{
    public CreateReservationCommandResponse()
    {
        Message =  "Rezervasyon bilgisi oluşturuldu.";
    }
}