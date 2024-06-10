using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.Category;

public class CreateCategoryDto : BaseResponse
{
    public string Name { get; set; }
    public bool Status { get; set; }
}