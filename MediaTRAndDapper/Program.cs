using FluentValidation;
using MediatR;
using Platform.Api.Database.Repositories.Abstract;
using Platform.Api.Database.Repositories.Concrete;
using FluentValidation.AspNetCore;
using MediaTRAndDapper.Database.DPContext;
using FastEndpoints;
using Microsoft.Extensions.DependencyInjection;
using MediaTRAndDapper.CQRS.Commands.Category.AddCategories;

var builder = WebApplication.CreateBuilder(args);

// Servisleri ekleyin
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// FluentValidation'� ekleyin
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<AddCategoryCommandHandler>();

// MediatR ba��ml�l�klar�n� ekleyin
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

// Database ve repository ba��ml�l�klar�n� ekleyin
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

// FastEndpoints servislerini ekleyin
builder.Services.AddFastEndpoints();

var app = builder.Build();

// Swagger�� etkinle�tir
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// FastEndpoints veya Minimal API'leri etkinle�tirin
app.MapFastEndpoints();

app.Run();