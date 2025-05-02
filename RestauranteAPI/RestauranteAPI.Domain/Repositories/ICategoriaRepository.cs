using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Domain.Repositories;

public interface ICategoriaRepository
{
    Task<List<Categoria>> ObtenerTodasAsync();
    Task CrearAsync(Categoria categoria);
}