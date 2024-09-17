using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;
using QRCodeOrderManager.Persistance.Repository;

namespace SignalR.DataAccessLayer.Repository;

public class TestimonialWriteRespository : WriteRepository<Testimonial>, ITestimonialWriteRepository
{
    public TestimonialWriteRespository(SignalRContext context) : base(context)
    {
    }
}