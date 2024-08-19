using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;

public class UpdateTestimonialCommandHandler(ITestimonialService service) : IRequestHandler<UpdateTestimonialCommand, UpdateTestimonialCommandResponse>
{
    public async Task<UpdateTestimonialCommandResponse> Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        await service.UpdateAsync(request);
        return new();
    }
}