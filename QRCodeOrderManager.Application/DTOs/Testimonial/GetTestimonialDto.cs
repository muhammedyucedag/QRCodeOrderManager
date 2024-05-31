namespace QRCodeOrderManager.Application.DTOs.Testimonial;

public class GetTestimonialDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageURL { get; set; }
    public bool Status { get; set; }
}