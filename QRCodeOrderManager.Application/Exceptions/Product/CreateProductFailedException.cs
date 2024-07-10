namespace QRCodeOrderManager.Application.Exceptions.Product;

public class CreateProductFailedException : BaseException
{
    public CreateProductFailedException() : base("Ürün oluşturma işlemi başarısız.")
    {
    }
}