using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Testimonial;
using QRCodeOrderManager.Application.Exceptions.Testimonial;

namespace QRCodeOrderManager.Application.Features.Queries.Testimonial.GetTestimonialById;

public class GetTestimonialByIdQueryCommandHandler(ITestimonialService service, IMapper mapper) : IRequestHandler<GetTestimonialByIdQueryCommand, TestimonialDto>
{
    public async Task<TestimonialDto> Handle(GetTestimonialByIdQueryCommand request, CancellationToken cancellationToken)
    {
        var testimonial = await service.GetByIdAsync(request.TestimonialId);
        if (testimonial is null)
            throw new NotFoundTestimonialException();

        return mapper.Map<TestimonialDto>(testimonial);
    }
}