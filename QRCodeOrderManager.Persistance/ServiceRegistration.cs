using Microsoft.Extensions.DependencyInjection;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Common;
using QRCodeOrderManager.Application.Repository;
using QRCodeOrderManager.Application.Repository.Product;
using QRCodeOrderManager.Persistance.Concrete;
using QRCodeOrderManager.Persistance.Repository.Product;
using QRCodeOrderManager.Persistance.Services;
using SignalR.DataAccessLayer.Repository;

namespace QRCodeOrderManager.Persistance;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        
        // Repository
        services.AddScoped<IAboutReadRepository, AboutReadRepository>();
        services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();

        services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
        services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

        services.AddScoped<IContactReadRepository, ContactReadRepository>();
        services.AddScoped<IContactWriteRepository, ContactWriteRepository>();
        
        services.AddScoped<IDiscountReadRepository, DiscountReadRepository>();
        services.AddScoped<IDiscountWriteRepository, DiscountWriteRepository>();
        
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        
        services.AddScoped<IReservationReadRepository, ReservationReadRepository>();
        services.AddScoped<IReservationWriteRepository, ReservationWriteRepository>();
        
        services.AddScoped<ISocialMediaReadRepository, SocialMediaReadRepository>();
        services.AddScoped<ISocialMediaWriteRepository, SocialMediaWriteRepository>();
        
        services.AddScoped<ISorterReadRepository, SorterReadRepository>();
        services.AddScoped<ISorterWriteRepository, SorterWriteRepository>();
        
        services.AddScoped<ITestimonialReadRepository, TestimonialReadRepository>();
        services.AddScoped<ITestimonialWriteRepository, TestimonialWriteRespository>();

        // Services
        services.AddScoped<IAboutService, AboutService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IDiscountService, DiscountService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IReservationService, ReservationService>();
        services.AddScoped<ISocialMediaService, SocialMediaService>();
        services.AddScoped<ISorterService, SorterService>();
        services.AddScoped<ITestimonialService, TestimonialService>();
        services.AddScoped<ISignalRContext, SignalRContext>();

    }
}