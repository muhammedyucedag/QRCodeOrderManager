﻿using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class TestimonialService : ITestimonailService
{
    public Task CreateAsync(Testimonial entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Testimonial entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Testimonial?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Testimonial>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }
}