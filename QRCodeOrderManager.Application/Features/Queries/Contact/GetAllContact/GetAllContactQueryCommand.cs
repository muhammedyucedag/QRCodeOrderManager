using MediatR;
using QRCodeOrderManager.Application.DTOs.Contact;

namespace QRCodeOrderManager.Application.Features.Queries.Contact.GetAllCategory;

public class GetAllContactQueryCommand : IRequest<ContactDto[]>
{
    
}