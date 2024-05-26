using Microsoft.EntityFrameworkCore;
using QRCodeOrderManager.Domain.Entities;

namespace SignalR.DataAccessLayer.Concrete;

public class SignalRContext : DbContext
{
    public SignalRContext(DbContextOptions<SignalRContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
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