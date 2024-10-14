using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Create;

public record CreateTestimonialCommandHandler(ITestimonialService TestimonialService, IMapper mapper) : IRequestHandler<CreateTestimonialCommand, CreateTestimonialCommandResponse>
{
    public async Task<CreateTestimonialCommandResponse> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var testimonial = mapper.Map<Domain.Entities.Testimonial>(request);
        await TestimonialService.CreateAsync(testimonial);
        return new();
    }
}