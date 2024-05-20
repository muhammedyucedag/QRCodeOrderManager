namespace SignalR.Entity.Entities;

public class Testimonial : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageURL { get; set; }
    public bool Status { get; set; }
}