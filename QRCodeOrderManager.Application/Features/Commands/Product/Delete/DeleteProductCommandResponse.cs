using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Delete;

public class DeleteProductCommandResponse : BaseResponse
{
    public DeleteProductCommandResponse()
    {
        Message = "Ürün başarıyla silindi.";
    }
}