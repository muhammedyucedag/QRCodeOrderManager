namespace QRCodeOrderManager.Application.DTOs.Discount;

public class ResultDiscountDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Amount { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}