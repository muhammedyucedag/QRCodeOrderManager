namespace QRCodeOrderManager.Application.Exceptions.Discount;

public class UpdateDiscountFailedException : BaseException
{
    public UpdateDiscountFailedException() : base("İndirim Güncellenemedi.")
    {
    }
}