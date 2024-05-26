namespace QRCodeOrderManager.Domain.Entities;

public class Discount : BaseEntity
{
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}