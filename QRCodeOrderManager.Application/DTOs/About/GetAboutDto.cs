namespace QRCodeOrderManager.Application.DTOs.About;

public class GetAboutDto
{
    public Guid id { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}