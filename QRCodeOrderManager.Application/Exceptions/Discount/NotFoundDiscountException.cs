namespace QRCodeOrderManager.Application.Exceptions.Discount;

public class NotFoundDiscountException : BaseException
{
    public NotFoundDiscountException() : base("İndirim Oluşturulmadı.")
    {
    }
}