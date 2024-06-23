using AutoMapper;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Exceptions.Contact;
using QRCodeOrderManager.Application.Features.Commands.Contact.Update;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Services;

public class ContactService : IContactService
{
    private readonly IContactReadRepository _contactReadRepository;
    private readonly IContactWriteRepository _contactWriteRepository;
    private readonly IMapper _mapper;

    public ContactService(IContactReadRepository contactReadRepository, IContactWriteRepository contactWriteRepository,
        IMapper mapper)
    {
        _contactReadRepository = contactReadRepository;
        _contactWriteRepository = contactWriteRepository;
        _mapper = mapper;
    }

    public async Task<Contact> CreateAsync(Contact entity)
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.UtcNow;

        var result = _contactWriteRepository.AddAsync(entity);
        if (result is null)
            throw new CreateContactFailedException();

        await _contactWriteRepository.SaveAsync();

        return entity;
    }

    public async Task<Contact> UpdateAsync(UpdateContactCommand command)
    {
        var contact = await _contactReadRepository.GetByIdAsync(command.Id);
        if (contact is null)
            throw new NotFoundContactException();

        contact.UpdatedDate = DateTime.UtcNow;

        _mapper.Map(command, contact);

        var result = _contactWriteRepository.Update(contact);
        if (!result)
            throw new UpdateContactFailedException();

        await _contactWriteRepository.SaveAsync();

        return contact;
    }

    public async Task DeleteAsync(Guid id)
    {
        var contact = await _contactReadRepository.GetByIdAsync(id);
        if (contact is null)
            throw new NotFoundContactException();

        await _contactWriteRepository.RemoveAsync(id);

        await _contactWriteRepository.SaveAsync();
    }

    public async Task<Contact?> GetByIdAsync(Guid id)
    {
        var contact = await _contactReadRepository.GetByIdAsync(id);
        if (contact is null)
            throw new NotFoundContactException();

        return contact;
    }

    public async Task<List<Contact>> GetListAllAsync()
    {
        var contacts = await _contactReadRepository.GetAllAsync();
        if (contacts is null)
            throw new NotFoundContactException();

        return contacts;
    }
}