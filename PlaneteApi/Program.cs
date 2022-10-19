using Data.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Data"))
           .LogTo(Console.WriteLine, LogLevel.Information)
);

builder.Services.AddMediatR(typeof(Facade.Societes.Societe.GetAll));
builder.Services.AddAutoMapper(typeof(Facade.Societes.Societe.GetAll));

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
