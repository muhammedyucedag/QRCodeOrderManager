namespace QRCodeOrderManager.Application.Exceptions.Category;

public class CreateCategoryFailedException : BaseException
{
    public CreateCategoryFailedException() : base("Kategori Bilgisi Oluşturulmadı.")
    {
    }
}