namespace QRCodeOrderManager.Application.Exceptions.Category;

public class NotFoundCategoryException : BaseException
{
    public NotFoundCategoryException() : base("Kategori Bilgisi Bulunmadı.")
    {
    }
}