using MediatR;
using QRCodeOrderManager.Application.DTOs.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetAllContact;

public record GetAllContactQueryCommand : IRequest<ContactDto[]>
{
    
}