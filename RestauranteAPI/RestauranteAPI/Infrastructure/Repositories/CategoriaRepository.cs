using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace RestauranteAPI.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> GetAllAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> CreateAsync(Categoria categoria)
        {
            _context.Categorias.Add(categoria); // <-- No es AddAsync aquí
            await _context.SaveChangesAsync();
            return categoria;
        }
    }
}