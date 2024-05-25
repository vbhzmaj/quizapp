using Microsoft.EntityFrameworkCore;
using backend_api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();

builder.Services.AddDbContext<QuizContext>(options => options.UseInMemoryDatabase("quiz"));


var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();


