using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces;

public interface ICategoriaService
{
    Task<List<Categoria>> ObtenerCategoriasAsync();
    Task<Categoria> CrearCategoriaAsync(Categoria categoria);
}