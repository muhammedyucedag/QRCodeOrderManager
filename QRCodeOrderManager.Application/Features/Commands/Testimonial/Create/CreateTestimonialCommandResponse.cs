using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Testimonial.Create;

public class CreateTestimonialCommandResponse : BaseResponse
{
    public CreateTestimonialCommandResponse()
    {
        Message = "Referans başarılı bir şekilde oluşturuldu.";
    }
}