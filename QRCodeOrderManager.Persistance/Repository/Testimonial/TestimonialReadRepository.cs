using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repository;

public class TestimonialReadRepository : ReadRepository<Testimonial>, ITestimonialReadRepository
{
    public TestimonialReadRepository(SignalRContext context) : base(context)
    {
    }
}