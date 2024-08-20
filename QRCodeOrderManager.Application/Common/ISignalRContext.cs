using Microsoft.EntityFrameworkCore;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Application.Common;

public interface ISignalRContext
{
    public DbSet<About> Abouts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<SocialMedia> SocialMedia { get; set; }
    public DbSet<Sorter> Sorters { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}