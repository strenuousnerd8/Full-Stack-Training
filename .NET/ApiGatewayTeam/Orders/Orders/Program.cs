using Microsoft.EntityFrameworkCore;
using Orders;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.



builder.Services.AddControllers();
string connectionString = builder.Configuration.GetConnectionString("AppDb");
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddDbContext<EmployeeDbContext>(x => x.UseSqlServer(connectionString));



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthorization();



app.MapControllers();



app.Run();