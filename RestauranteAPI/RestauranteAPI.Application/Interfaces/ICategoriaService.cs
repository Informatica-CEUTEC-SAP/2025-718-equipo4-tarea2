susing RestauranteAPI.Application.DTOs;

namespace RestauranteAPI.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDto>> ObtenerTodasAsync();
        Task<CategoriaDto> CrearAsync(CategoriaDto categoriaDto);
    }
}