using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Update;

public class UpdateProductCommandResponse : BaseResponse
{
    public UpdateProductCommandResponse()
    {
        Message = "Ürün başarılı bir şekilde güncellendi.";
    }
}