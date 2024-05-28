using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class TestimonialWriteRespository : WriteRepository<Testimonial>, ITestimonialWriteRepository
{
    public TestimonialWriteRespository(SignalRContext context) : base(context)
    {
    }
}