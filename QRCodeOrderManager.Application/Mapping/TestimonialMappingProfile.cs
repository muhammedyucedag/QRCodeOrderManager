using AutoMapper;
using QRCodeOrderManager.Application.DTOs.Testimonial;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Mapping;

public class TestimonialMappingProfile : Profile
{
    public TestimonialMappingProfile()
    {
        CreateMap<Testimonial, TestimonialDto>().ReverseMap();
    }
}