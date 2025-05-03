using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;

namespace RestauranteAPI.Application.Services;

public class PlatoService : IPlatoService
{
    private readonly IPlatoRepository _repo;

    public PlatoService(IPlatoRepository repo) => _repo = repo;

    public async Task<IEnumerable<Plato>> GetAllAsync() => await _repo.GetAllAsync();

    public async Task<Plato?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

    public async Task<IEnumerable<Plato>> GetByCategoriaAsync(string categoria) =>
        await _repo.GetByCategoriaAsync(categoria);

    public async Task<IEnumerable<Plato>> GetByPrecioRangeAsync(decimal min, decimal max) =>
        await _repo.GetByPrecioRangeAsync(min, max);

    public async Task<Plato> CreateAsync(Plato plato) => await _repo.AddAsync(plato);

    public async Task UpdateAsync(int id, Plato plato)
    {
        plato.Id = id;
        await _repo.UpdateAsync(plato);
    }

    public async Task DeleteAsync(int id) => await _repo.DeleteAsync(id);
}