using Microsoft.EntityFrameworkCore;
using VehicleLookup.Core.VehicleLookup;
using VehicleLookup.Core.VehicleLookupService;
using VehicleLookup.Models.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<masterContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MySqlConnection")));

builder.Services.AddScoped<IVehicleLookup, VehicleLookupService>();

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
