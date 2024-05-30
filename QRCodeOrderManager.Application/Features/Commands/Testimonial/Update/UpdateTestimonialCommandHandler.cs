using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;

public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
{
    public Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}