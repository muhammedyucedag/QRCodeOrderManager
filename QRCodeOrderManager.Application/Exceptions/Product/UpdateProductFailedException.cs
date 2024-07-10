namespace QRCodeOrderManager.Application.Exceptions.Product;

public class UpdateProductFailedException : BaseException
{
    public UpdateProductFailedException() : base("Ürün güncellenmedi.")
    {
    }
}