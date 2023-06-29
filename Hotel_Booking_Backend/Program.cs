using HotelBookingService.Models;
using HotelBookingService.DAO;
using HotelBookingService.Services;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Add coneection to the Azure SQL
builder.Services.AddDbContext<HotelBookingContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AzureConnection")));

// Add DAO and Service layer
builder.Services.AddScoped<HotelDAO>();
builder.Services.AddScoped<RoomDAO>();
builder.Services.AddScoped<HotelService>();
builder.Services.AddScoped<IRoomService>();


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

