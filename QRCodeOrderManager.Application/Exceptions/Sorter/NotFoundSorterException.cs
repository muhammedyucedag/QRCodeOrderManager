namespace QRCodeOrderManager.Application.Exceptions.Sorter;

public class NotFoundSorterException : BaseException
{
    public NotFoundSorterException() : base("Sıralayıcı bulunamadı.")
    {
    }
}