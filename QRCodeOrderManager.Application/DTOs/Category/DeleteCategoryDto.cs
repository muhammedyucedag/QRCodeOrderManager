using QRCodeOrderManager.Application.Features.Commands.Response;

namespace QRCodeOrderManager.Application.DTOs.Category;

public class DeleteCategoryDto : BaseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}