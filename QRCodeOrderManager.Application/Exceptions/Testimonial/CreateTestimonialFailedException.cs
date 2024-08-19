namespace QRCodeOrderManager.Application.Exceptions.Testimonial;

public class CreateTestimonialFailedException : BaseException
{
    public CreateTestimonialFailedException() : base("Referans oluşturma işlemi başarısız.")
    {
    }
}