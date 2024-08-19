using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Testimonial;
using QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class TestimonialService(ITestimonialReadRepository testimonialReadRepository, ITestimonialWriteRepository testimonialWriteRepository, IMapper mapper) : ITestimonialService
{
    public async Task<Testimonial> CreateAsync(Testimonial entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = testimonialWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateTestimonialFailedException();

        await testimonialWriteRepository.SaveAsync();
        return entity;
    }

    public async Task DeleteAsync(Guid id)
    {
        var testimonial = testimonialReadRepository.GetByIdAsync(id);
        if (testimonial is null)
            throw new NotFoundTestimonialException();

        await testimonialWriteRepository.RemoveAsync(id);
        await testimonialWriteRepository.SaveAsync();
    }

    public Task<Testimonial?> GetByIdAsync(Guid id)
    {
        var testimonial = testimonialReadRepository.GetByIdAsync(id);
        if (testimonial is null)
            throw new NotFoundTestimonialException();

        return testimonial;
    }

    public async Task<List<Testimonial>> GetListAllAsync()
    {
        var testimonials = await testimonialReadRepository.GetAllAsync();
        if (testimonials is null)
            throw new NotFoundTestimonialException();

        return testimonials;
    }

    public async Task<Testimonial> UpdateAsync(UpdateTestimonialCommand command)
    {
        var testimonial = await testimonialReadRepository.GetByIdAsync(command.Id);
        if (testimonial is null)
            throw new NotFoundTestimonialException();

        testimonial.UpdatedDate = DateTime.UtcNow;

        mapper.Map(command, testimonial);

        var result = testimonialWriteRepository.Update(testimonial);
        if (!result)
            throw new UpdateTestimonialFailedException();

        await testimonialWriteRepository.SaveAsync();

        return testimonial;
    }
}