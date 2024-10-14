namespace SignalRWebUI.Dtos.CategoryDtos;

public record CategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}