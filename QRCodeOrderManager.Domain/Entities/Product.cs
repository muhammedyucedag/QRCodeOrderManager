namespace QRCodeOrderManager.Domain.Entities;

public class Product : BaseEntity
{
    public Guid CategoryId { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
    
    //Relations    
    public Category Category { get; set; }
}