using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Product.Update;

public class UpdateProductCommand : IRequest<UpdateProductCommandResponse>
{
    public Guid Id { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}