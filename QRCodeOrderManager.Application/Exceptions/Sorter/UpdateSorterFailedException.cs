namespace QRCodeOrderManager.Application.Exceptions.Sorter;

public class UpdateSorterFailedException : BaseException
{
    public UpdateSorterFailedException() : base("Sıralayıcı güncellenmedi.")
    {
    }
}