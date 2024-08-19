namespace QRCodeOrderManager.Application.Exceptions.Testimonial;

public class NotFoundTestimonialException : BaseException
{
    public NotFoundTestimonialException() : base("Referans bulunamadı.")
    {
    }
}