using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Discount.Create;

public class CreateDiscountCommandResponse : BaseResponse
{
    public CreateDiscountCommandResponse()
    {
        Message = "İndirim başarılı bir şekilde oluşturuldu";
    }
}