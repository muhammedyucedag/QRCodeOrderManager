using QRCodeOrderManager.Application.Features.Commands.Contact.Update;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Abstractions.Services;

public interface IContactService : IGenericService<Contact>
{
    Task<Contact> UpdateAsync(UpdateContactCommand command);
}