using Dot_Net_EF_MySqlDb.API.Controllers;
using Dot_Net_EF_MySqlDb.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbontext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("MysqlDbConnectionString"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MysqlDbConnectionString")));
});

builder.Services.AddScoped<RegionController>();

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
