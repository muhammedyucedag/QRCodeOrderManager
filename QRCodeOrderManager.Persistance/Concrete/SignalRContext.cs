using Microsoft.EntityFrameworkCore;
using QRCodeOrderManager.Domain.Entities;

namespace QRCodeOrderManager.Persistance.Concrete;

public class SignalRContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=QrCodeOrderManager;Username=user;Password=password");
        }
    }

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