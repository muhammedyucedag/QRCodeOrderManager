namespace QRCodeOrderManager.Application.Exceptions.Product;

public class NotFoundProductException : BaseException
{
    public NotFoundProductException() : base("Ürün bulunamadı.")
    {
    }
}