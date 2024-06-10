namespace QRCodeOrderManager.Application.DTOs.Category;

public class GetByIdCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}