namespace QRCodeOrderManager.Application.Exceptions.Discount;

public class CreateDiscountFailedException : BaseException
{
    public CreateDiscountFailedException() : base("İndirim oluşturma işlemi başarısız.")
    {
    }
}