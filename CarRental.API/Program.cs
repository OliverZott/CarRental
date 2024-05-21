using CarRental.Core.Services;
using CarRental.DatabaseManager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("CarRentalDbConnectionString");
builder.Services.AddDbContext<CarRentalDbContext>(options => { options.UseNpgsql(connectionString); });

builder.Services.AddControllers();

// builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowAllPolicy", p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});


builder.Services.AddScoped<CarDatabaseService>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Database migration on startup
using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<CarRentalDbContext>();
await context.Database.MigrateAsync();

app.UseHttpsRedirection();
app.UseCors("MyAllowAllPolicy");

app.MapControllers();

app.Run();