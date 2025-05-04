using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetAllAsync();
        Task<Categoria> CreateAsync(Categoria categoria); // <-- Línea clave
    }
}