using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Delete;

public class DeleteTestimonialCommandHandler(ITestimonialService testimonialService) : IRequestHandler<DeleteTestimonialCommand, DeleteTestimonialCommandResponse>
{
    public async Task<DeleteTestimonialCommandResponse> Handle(DeleteTestimonialCommand request, CancellationToken cancellationToken)
    {
        await testimonialService.DeleteAsync(request.TestimonialId);
        return new();
    }
}