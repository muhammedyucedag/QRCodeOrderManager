using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;
using QRCodeOrderManager.Persistance.Concrete;
using QRCodeOrderManager.Persistance.Repository;

namespace SignalR.DataAccessLayer.Repository;

public class TestimonialReadRepository : ReadRepository<Testimonial>, ITestimonialReadRepository
{
    public TestimonialReadRepository(SignalRContext context) : base(context)
    {
    }
}