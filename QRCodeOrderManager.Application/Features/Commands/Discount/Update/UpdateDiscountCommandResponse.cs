using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Update;

public class UpdateDiscountCommandResponse : BaseResponse
{
    public UpdateDiscountCommandResponse()
    {
        Message = "İndirim başarılı bir şekilde güncellendi";
    }
}