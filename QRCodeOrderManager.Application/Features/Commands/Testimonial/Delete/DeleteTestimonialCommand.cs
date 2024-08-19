using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Delete;

public class DeleteTestimonialCommand : IRequest<DeleteTestimonialCommandResponse>
{
    public Guid TestimonialId { get; set; }
}