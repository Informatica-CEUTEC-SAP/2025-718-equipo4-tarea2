using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Controllers;

[ApiController]
[Route("api/platos")]
public class Platos : ControllerBase
{
    private readonly IPlatoService _service;

    public Platos(IPlatoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) =>
        Ok(await _service.GetByIdAsync(id));

    [HttpPost]
    public async Task<IActionResult> Create(Plato plato) =>
        Ok(await _service.CreateAsync(plato));

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Plato plato) =>
        Ok(await _service.UpdateAsync(id, plato));

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id) =>
        Ok(await _service.DeleteAsync(id));

    [HttpGet("categoria/{nombre}")]
    public async Task<IActionResult> GetByCategoria(string nombre) =>
        Ok(await _service.GetByCategoriaAsync(nombre));

    [HttpGet("precio")]
    public async Task<IActionResult> GetByPrecio([FromQuery] decimal min, [FromQuery] decimal max) =>
        Ok(await _service.GetByPrecioRangeAsync(min, max));
}