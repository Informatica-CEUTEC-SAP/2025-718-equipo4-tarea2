using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;

namespace RestauranteAPI.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Categoria>> ObtenerCategoriasAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Categoria> CrearCategoriaAsync(Categoria categoria)
        {
            return await _repository.CreateAsync(categoria); // <-- Línea clave
        }
    }
}