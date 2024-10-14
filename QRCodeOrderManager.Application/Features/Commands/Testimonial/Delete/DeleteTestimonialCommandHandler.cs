using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Delete;

public record DeleteTestimonialCommandHandler(ITestimonialService TestimonialService) : IRequestHandler<DeleteTestimonialCommand, DeleteTestimonialCommandResponse>
{
    public async Task<DeleteTestimonialCommandResponse> Handle(DeleteTestimonialCommand request, CancellationToken cancellationToken)
    {
        await TestimonialService.DeleteAsync(request.TestimonialId);
        return new();
    }
}