using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Create;

public class CreateProductCommandResponse : BaseResponse
{
    public CreateProductCommandResponse()
    {
        Message =  "Ürün bilgisi oluşturuldu.";
    }
}