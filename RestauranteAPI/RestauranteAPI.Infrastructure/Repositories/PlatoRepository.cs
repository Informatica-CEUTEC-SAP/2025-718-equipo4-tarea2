using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Infrastructure.Repositories
{
    public class PlatoRepository : IPlatoRepository
    {
        private readonly RestauranteDbContext _context;

        public PlatoRepository(RestauranteDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plato>> GetAllAsync()
        {
            return await _context.Platos.Include(p => p.Categoria).ToListAsync();
        }

        public async Task<Plato?> GetByIdAsync(int id)
        {
            return await _context.Platos.Include(p => p.Categoria)
                                        .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Plato> CreateAsync(Plato plato)
        {
            _context.Platos.Add(plato);
            await _context.SaveChangesAsync();
            return plato;
        }

        public async Task<bool> UpdateAsync(Plato plato)
        {
            _context.Platos.Update(plato);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var plato = await _context.Platos.FindAsync(id);
            if (plato == null) return false;

            _context.Platos.Remove(plato);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Plato>> GetByCategoriaAsync(string nombreCategoria)
        {
            return await _context.Platos
                .Include(p => p.Categoria)
                .Where(p => p.Categoria.Nombre.ToLower() == nombreCategoria.ToLower())
                .ToListAsync();
        }

        public async Task<IEnumerable<Plato>> GetByPrecioRangeAsync(decimal min, decimal max)
        {
            return await _context.Platos
                .Where(p => p.Precio >= min && p.Precio <= max)
                .ToListAsync();
        }
    }
}
