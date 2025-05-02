using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Configurar servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔌 Conexión a PostgreSQL
builder.Services.AddDbContext<RestauranteDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 💡 Inyección de dependencias (Services y Repositories)
builder.Services.AddScoped<IPlatoService, PlatoService>();
builder.Services.AddScoped<IPlatoRepository, PlatoRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

// 🌐 Configurar CORS si es necesario
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// 📦 Migraciones automáticas (opcional para desarrollo)
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<RestauranteDbContext>();
    dbContext.Database.Migrate(); // Aplica automáticamente las migraciones
}

// 🚀 Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();