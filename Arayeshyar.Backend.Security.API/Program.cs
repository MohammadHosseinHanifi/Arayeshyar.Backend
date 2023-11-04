using Arayeshyar.Backend.Core.Entities;
using Arayeshyar.Backend.Infrastructure.DB;
using Arayeshyar.Backend.Security.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ArayeshyarDB>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
    });

builder.Services.
AddCors(options => options
.AddDefaultPolicy(builder => builder
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.MapPost("/adminlogin", (ArayeshyarDB db, LoginRequestDTO login) =>
    {
        if (!db.SystemAdmins.Any())
        {
            var firstadmin = new SystemAdmin("ali", "123", "333444");
            db.SystemAdmins.Add(firstadmin);
            db.SaveChanges();

        }

        var result = db.SystemAdmins
        .Where(m => m.Username == login.Username && m.Password == login.Password).FirstOrDefault();
        if (result != null)
        {
            return new
            {
                IsOK = true,
                Message = "welcome"
            };
        }
        return new
        {
            IsOK = false,
            Message = "notwelcome"
        };



    });

app.Run();


