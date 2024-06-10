namespace QRCodeOrderManager.Application.Exceptions.Category;

public class UpdateCategoryFailedException : BaseException
{
    public UpdateCategoryFailedException() : base("Kategori bilgisi güncellenemedi.")
    {
    }
}