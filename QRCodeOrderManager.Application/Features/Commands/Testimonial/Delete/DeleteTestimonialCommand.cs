using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Delete;

public record DeleteTestimonialCommand : IRequest<DeleteTestimonialCommandResponse>
{
    public Guid TestimonialId { get; set; }
}