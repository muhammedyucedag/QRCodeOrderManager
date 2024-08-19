namespace QRCodeOrderManager.Application.Exceptions.Testimonial;

public class UpdateTestimonialFailedException : BaseException
{
    public UpdateTestimonialFailedException() : base("Referans güncellenmedi.")
    {
    }
}