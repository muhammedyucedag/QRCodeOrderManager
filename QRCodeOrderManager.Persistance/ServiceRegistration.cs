using Microsoft.Extensions.DependencyInjection;
using QRCodeOrderManager.Application.Abstractions.Services;
using QRCodeOrderManager.Application.Repository;
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
        
        // Services
        services.AddScoped<IAboutService, AboutService>();
        services.AddScoped<ICategoryService, CategoryService>();
    }
}