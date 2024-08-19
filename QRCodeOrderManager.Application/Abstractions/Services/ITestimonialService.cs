using QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface ITestimonialService : IGenericService<Testimonial>
{
    Task<Testimonial> UpdateAsync(UpdateTestimonialCommand command);
}