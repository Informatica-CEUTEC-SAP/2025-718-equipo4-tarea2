using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Data;
using RestauranteAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLConnection")));

// Inyección de dependencias
builder.Services.AddScoped<IPlatoRepository, PlatoRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IPlatoService, PlatoService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

// Otros servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();