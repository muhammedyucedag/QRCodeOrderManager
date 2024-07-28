namespace QRCodeOrderManager.Application.Exceptions.Reservation;

public class CreateReservationFailedException : BaseException
{
    public CreateReservationFailedException() : base("Rezervasyon oluşturma işlemi başarısız.")
    {
    }
}