using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Update;

public class UpdateTestimonialCommandResponse : BaseResponse
{
    public UpdateTestimonialCommandResponse()
    {
        Message = "Referans başarılı bir şekilde güncellendi.";
    }
}