using RestauranteAPI.Application.DTOs;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;

namespace RestauranteAPI.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<CategoriaDto>> ObtenerTodasAsync()
        {
            var categorias = await _categoriaRepository.ObtenerTodasAsync();
            return categorias.Select(c => new CategoriaDto
            {
                Id = c.Id,
                Nombre = c.Nombre
            });
        }

        public async Task<CategoriaDto> CrearAsync(CategoriaDto categoriaDto)
        {
            var categoria = new Categoria
            {
                Nombre = categoriaDto.Nombre
            };

            await _categoriaRepository.CrearAsync(categoria);
            categoriaDto.Id = categoria.Id;
            return categoriaDto;
        }
    }
}