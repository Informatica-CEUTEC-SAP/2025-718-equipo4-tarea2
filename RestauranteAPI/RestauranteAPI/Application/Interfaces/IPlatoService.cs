using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces;

public interface IPlatoService
{
    Task<IEnumerable<Plato>> GetAllAsync();
    Task<Plato?> GetByIdAsync(int id);
    Task<IEnumerable<Plato>> GetByCategoriaAsync(string categoria);
    Task<IEnumerable<Plato>> GetByPrecioRangeAsync(decimal min, decimal max);
    Task<Plato> CreateAsync(Plato plato);
    Task UpdateAsync(int id, Plato plato);
    Task DeleteAsync(int id);
}