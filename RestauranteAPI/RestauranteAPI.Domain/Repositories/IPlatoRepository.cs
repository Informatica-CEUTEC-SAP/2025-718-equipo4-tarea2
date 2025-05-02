using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Domain.Repositories;

public interface IPlatoRepository
{
    Task<List<Plato>> ObtenerTodosAsync();
    Task<Plato?> ObtenerPorIdAsync(int id);
    Task<List<Plato>> FiltrarPorCategoriaAsync(string categoria);
    Task<List<Plato>> FiltrarPorPrecioAsync(decimal min, decimal max);
    Task CrearAsync(Plato plato);
    Task ActualizarAsync(Plato plato);
    Task EliminarAsync(int id);
}