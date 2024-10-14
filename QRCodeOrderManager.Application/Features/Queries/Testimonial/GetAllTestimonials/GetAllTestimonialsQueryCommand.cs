using MediatR;
using QRCodeOrderManager.Application.DTOs.Testimonial;

namespace QRCodeOrderManager.Application.Features.Queries.Testimonial.GetAllTestimonials;

public record GetAllTestimonialsQueryCommand : IRequest<TestimonialDto[]>
{
}