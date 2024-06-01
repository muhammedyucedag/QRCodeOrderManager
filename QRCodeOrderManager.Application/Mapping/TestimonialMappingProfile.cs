using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Testimonial;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class TestimonialMappingProfile : Profile
{
    public TestimonialMappingProfile()
    {
        CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
    }
}