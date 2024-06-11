using MediatR;
using QRCodeOrderManager.Application.DTOs.Contact;

namespace QRCodeOrderManager.Application.Features.Commands.Contact.Create;

public class CreateContactCommand : IRequest<CreateContactCommandResponse>
{
    public string Location { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public string FooterDescription { get; set; }
}