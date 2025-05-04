using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Domain.Interfaces;

public interface IPlatoRepository
{
    Task<IEnumerable<Plato>> GetAllAsync();
    Task<Plato?> GetByIdAsync(int id);
    Task<IEnumerable<Plato>> GetByCategoriaAsync(string nombreCategoria);
    Task<IEnumerable<Plato>> GetByPrecioRangeAsync(decimal min, decimal max);
    Task<Plato> AddAsync(Plato plato);
    Task UpdateAsync(Plato plato);
    Task DeleteAsync(int id);
}