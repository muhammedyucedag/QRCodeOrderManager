using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Create;

public class CreateTestimonialCommand : IRequest<CreateTestimonialCommandResponse>
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageURL { get; set; }
    public bool Status { get; set; }
}