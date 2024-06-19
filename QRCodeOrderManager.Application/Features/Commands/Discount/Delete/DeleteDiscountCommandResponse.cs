using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Delete;

public class DeleteDiscountCommandResponse : BaseResponse
{
    public DeleteDiscountCommandResponse()
    {
        Message = "İndirim başarılı bir şekilde silindi.";
    }
}