namespace QRCodeOrderManager.Application.Exceptions.Sorter;

public class UpdateSorterFailedException
{
    
}

public class UpdateSorterFailedException : BaseException
{
    public UpdateSocialMediaFailedException() : base("Sosyal medya güncellenmedi.")
    {
    }
}