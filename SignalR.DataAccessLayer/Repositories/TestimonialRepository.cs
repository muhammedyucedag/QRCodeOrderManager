using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Repositories;

public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
{
    public TestimonialRepository(SignalRContext signalRContext) : base(signalRContext)
    {
    }
}