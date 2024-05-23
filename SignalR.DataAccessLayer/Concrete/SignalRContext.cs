using Microsoft.EntityFrameworkCore;
using SignalR.Entity.Entities;

namespace SignalR.DataAccessLayer.Concrete;

public class SignalRContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SignalRApi;");
        base.OnConfiguring(optionsBuilder);
    }
    
    public DbSet<About> Abouts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<SocailMedia> SocailMedia { get; set; }
    public DbSet<Sorter> Sorters { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}