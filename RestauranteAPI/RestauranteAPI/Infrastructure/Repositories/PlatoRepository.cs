using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Data;

namespace RestauranteAPI.Infrastructure.Repositories;

public class PlatoRepository : IPlatoRepository
{
    private readonly AppDbContext _context;

    public PlatoRepository(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Plato>> GetAllAsync() =>
        await _context.Platos.Include(p => p.Categoria).ToListAsync();

    public async Task<Plato?> GetByIdAsync(int id) =>
        await _context.Platos.Include(p => p.Categoria).FirstOrDefaultAsync(p => p.Id == id);

    public async Task<IEnumerable<Plato>> GetByCategoriaAsync(string nombreCategoria) =>
        await _context.Platos
            .Include(p => p.Categoria)
            .Where(p => p.Categoria.Nombre.ToLower() == nombreCategoria.ToLower())
            .ToListAsync();

    public async Task<IEnumerable<Plato>> GetByPrecioRangeAsync(decimal min, decimal max) =>
        await _context.Platos
            .Include(p => p.Categoria)
            .Where(p => p.Precio >= min && p.Precio <= max)
            .ToListAsync();

    public async Task<Plato> AddAsync(Plato plato)
    {
        _context.Platos.Add(plato);
        await _context.SaveChangesAsync();
        return plato;
    }

    public async Task UpdateAsync(Plato plato)
    {
        _context.Entry(plato).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var plato = await _context.Platos.FindAsync(id);
        if (plato is not null)
        {
            _context.Platos.Remove(plato);
            await _context.SaveChangesAsync();
        }
    }
}