using Microsoft.EntityFrameworkCore;
using SignalR.Entity.Entities;

namespace SignalR.Entity.Repositories;

//IRepository<T> arayüzündeki DbSet<T> Table özelliği, belirli bir varlık tipi için veri tabanında
//CRUD işlemlerini kolaylaştırmak amacıyla Entity Framework Core tarafından sağlanan veri kümesine erişim sağlar.
public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}