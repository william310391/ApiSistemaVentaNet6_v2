using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using SistemaVenta.Infraestructura.Filters;
using SistemaVenta.Negocio.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var provider = builder.Services.BuildServiceProvider();
IConfiguration Configuration = provider.GetRequiredService<IConfiguration>();


// Add services to the container.

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers(option =>
{
    option.Filters.Add<GlobalExceptionFilter>();
}).AddNewtonsoftJson(option =>
{
    option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    option.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
})
.ConfigureApiBehaviorOptions(option =>
{
    option.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddOptions(Configuration);
builder.Services.AddDbContexts(Configuration);
builder.Services.AddServices();
//services.AddTransient<IUnitOfWorkService, UnitOfWorkService>();
//builder.Services.AddSwagger(Configuration, Assembly.GetExecutingAssembly().GetName().Name);
builder.Services.AddJWTAuthentication(Configuration);
builder.Services.AddMvc(option =>
{
    option.Filters.Add<ValidationFilter>();
});


#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
builder.Services.AddFluentValidation(option =>
    {
        option.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
    });
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
