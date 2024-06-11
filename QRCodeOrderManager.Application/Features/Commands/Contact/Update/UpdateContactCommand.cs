using MediatR;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Update;

public class UpdateContactCommand : IRequest<UpdateContactCommandResponse>
{
    public Guid Id { get; set; }
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}