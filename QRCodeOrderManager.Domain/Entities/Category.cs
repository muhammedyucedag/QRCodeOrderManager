namespace QRCodeOrderManager.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public bool Status { get; set; }
}