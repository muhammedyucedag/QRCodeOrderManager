using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Create;

public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand, CreateTestimonialCommandResponse>
{
    public Task<CreateTestimonialCommandResponse> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}