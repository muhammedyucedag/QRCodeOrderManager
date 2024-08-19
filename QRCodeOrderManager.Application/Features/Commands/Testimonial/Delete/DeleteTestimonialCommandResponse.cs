using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Delete;

public class DeleteTestimonialCommandResponse : BaseResponse
{
    public DeleteTestimonialCommandResponse()
    {
        Message = "Referans başarılı bir şekilde silindi.";
    }
}