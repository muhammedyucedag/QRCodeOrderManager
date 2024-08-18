namespace QRCodeOrderManager.Application.Exceptions.Sorter;

public class CreateSorterFailedException : BaseException
{
    public CreateSorterFailedException() : base("Sıralayıcı oluşturma işlemi başarısız.")
    {
    }
}