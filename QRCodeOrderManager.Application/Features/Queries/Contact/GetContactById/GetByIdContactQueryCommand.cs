using MediatR;
using QRCodeOrderManager.Application.DTOs.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetContactById;

public record GetByIdContactQueryCommand : IRequest<ContactDto>
{
    public Guid ContactId { get; set; }
}