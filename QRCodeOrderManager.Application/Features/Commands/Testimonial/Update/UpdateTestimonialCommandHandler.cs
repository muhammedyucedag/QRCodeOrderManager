using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;

public record UpdateTestimonialCommandHandler(ITestimonialService TestimonialService) : IRequestHandler<UpdateTestimonialCommand, UpdateTestimonialCommandResponse>
{
    public async Task<UpdateTestimonialCommandResponse> Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        await TestimonialService.UpdateAsync(request);
        return new();
    }
}