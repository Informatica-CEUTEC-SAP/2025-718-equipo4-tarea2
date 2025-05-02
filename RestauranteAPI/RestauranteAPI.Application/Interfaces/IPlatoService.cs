using RestauranteAPI.Application.DTOs;

namespace RestauranteAPI.Application.Interfaces
{
    public interface IPlatoService
    {
        Task<IEnumerable<PlatoDto>> ObtenerTodosAsync();
        Task<PlatoDto?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<PlatoDto>> ObtenerPorCategoriaAsync(string categoria);
        Task<IEnumerable<PlatoDto>> ObtenerPorRangoPrecioAsync(decimal min, decimal max);
        Task<PlatoDto> CrearAsync(PlatoDto platoDto);
        Task<bool> ActualizarAsync(int id, PlatoDto platoDto);
        Task<bool> EliminarAsync(int id);
    }
}