namespace QRCodeOrderManager.Application.Exceptions.Reservation;

public class UpdateReservationFailedException : BaseException
{
    public UpdateReservationFailedException() : base("Rezervasyon güncellenmedi.")
    {
    }
}