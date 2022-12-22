using Inventory;
using Microsoft.EntityFrameworkCore;
using Service_Discovery.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<InventoryDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddConsulConfig();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseConsul();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
