using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using modelDB;
using modelDB.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WorldCitySourceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"))
);

builder.Services.AddIdentity<WorldCityUser, IdentityRole>()
    .AddEntityFrameworkStores<WorldCitySourceContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(option => option.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
