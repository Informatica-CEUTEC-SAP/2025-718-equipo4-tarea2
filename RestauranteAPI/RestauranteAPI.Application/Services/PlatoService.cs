using RestauranteAPI.Application.DTOs;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;

namespace RestauranteAPI.Application.Services
{
    public class PlatoService : IPlatoService
    {
        private readonly IPlatoRepository _platoRepository;

        public PlatoService(IPlatoRepository platoRepository)
        {
            _platoRepository = platoRepository;
        }

        public async Task<IEnumerable<PlatoDto>> ObtenerTodosAsync()
        {
            var platos = await _platoRepository.ObtenerTodosAsync();
            return platos.Select(p => new PlatoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio,
                CategoriaId = p.CategoriaId
            });
        }

        public async Task<PlatoDto?> ObtenerPorIdAsync(int id)
        {
            var plato = await _platoRepository.ObtenerPorIdAsync(id);
            return plato == null ? null : new PlatoDto
            {
                Id = plato.Id,
                Nombre = plato.Nombre,
                Descripcion = plato.Descripcion,
                Precio = plato.Precio,
                CategoriaId = plato.CategoriaId
            };
        }

        public async Task<IEnumerable<PlatoDto>> ObtenerPorCategoriaAsync(string categoria)
        {
            var platos = await _platoRepository.ObtenerPorCategoriaAsync(categoria);
            return platos.Select(p => new PlatoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio,
                CategoriaId = p.CategoriaId
            });
        }

        public async Task<IEnumerable<PlatoDto>> ObtenerPorRangoPrecioAsync(decimal min, decimal max)
        {
            var platos = await _platoRepository.ObtenerPorRangoPrecioAsync(min, max);
            return platos.Select(p => new PlatoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio,
                CategoriaId = p.CategoriaId
            });
        }

        public async Task<PlatoDto> CrearAsync(PlatoDto platoDto)
        {
            var plato = new Plato
            {
                Nombre = platoDto.Nombre,
                Descripcion = platoDto.Descripcion,
                Precio = platoDto.Precio,
                CategoriaId = platoDto.CategoriaId
            };
            await _platoRepository.CrearAsync(plato);
            platoDto.Id = plato.Id;
            return platoDto;
        }

        public async Task<bool> ActualizarAsync(int id, PlatoDto platoDto)
        {
            var plato = await _platoRepository.ObtenerPorIdAsync(id);
            if (plato == null) return false;

            plato.Nombre = platoDto.Nombre;
            plato.Descripcion = platoDto.Descripcion;
            plato.Precio = platoDto.Precio;
            plato.CategoriaId = platoDto.CategoriaId;

            await _platoRepository.ActualizarAsync(plato);
            return true;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            return await _platoRepository.EliminarAsync(id);
        }
    }
}
