namespace QRCodeOrderManager.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public bool Status { get; set; }
    
    //Relations
    public ICollection<Product> Products { get; set; }
}