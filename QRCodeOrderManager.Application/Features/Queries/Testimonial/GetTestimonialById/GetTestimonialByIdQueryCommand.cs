using MediatR;
using QRCodeOrderManager.Application.DTOs.Testimonial;

namespace QRCodeOrderManager.Application.Features.Queries.Testimonial.GetTestimonialById;

public record GetTestimonialByIdQueryCommand : IRequest<TestimonialDto>
{
    public Guid TestimonialId { get; set; }
}