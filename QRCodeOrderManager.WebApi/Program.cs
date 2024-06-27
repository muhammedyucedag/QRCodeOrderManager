using System.Reflection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QRCodeOrderManager.Persistance;
using QRCodeOrderManager.Persistance.Concrete;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});
    
builder.Services.AddPersistenceServices();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddDbContext<SignalRContext>(options => { options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")); });
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();