namespace QRCodeOrderManager.Application.Exceptions.Reservation;

public class NotFoundReservationException : BaseException
{
    public NotFoundReservationException() : base("Rezervasyon bulunamadı.")
    {
    }
}