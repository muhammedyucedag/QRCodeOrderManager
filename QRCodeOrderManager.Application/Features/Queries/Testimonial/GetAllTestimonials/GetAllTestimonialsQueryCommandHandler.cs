using AutoMapper;
using MediatR;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.DTOs.Testimonial;
using QRCodeOrderManager.Application.Exceptions.Testimonial;

namespace QRCodeOrderManager.Application.Features.Queries.Testimonial.GetAllTestimonials;

public class GetAllTestimonialsQueryCommandHandler(ITestimonialService service, IMapper mapper) : IRequestHandler<GetAllTestimonialsQueryCommand, TestimonialDto[]>
{
    public async Task<TestimonialDto[]> Handle(GetAllTestimonialsQueryCommand request, CancellationToken cancellationToken)
    {
        var testimonial = await service.GetListAllAsync();
        if (testimonial is null)
            throw new NotFoundTestimonialException();

        var testimonialsDto = mapper.Map<TestimonialDto[]>(testimonial);

        return testimonialsDto;
    }
}