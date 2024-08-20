using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Testimonial;
using QRCodeOrderManager.Application.Features.Commands.Testimonial.Create;
using QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class TestimonialMappingProfile : Profile
{
    public TestimonialMappingProfile()
    {
        CreateMap<Testimonial, TestimonialDto>().ReverseMap();
        CreateMap<CreateTestimonialCommand, Testimonial>().ReverseMap();
        CreateMap<UpdateTestimonialCommand, Testimonial>().ReverseMap();
    }
}