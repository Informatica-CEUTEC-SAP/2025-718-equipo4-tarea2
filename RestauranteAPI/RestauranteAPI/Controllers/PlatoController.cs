using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlatoController : ControllerBase
{
    private readonly IPlatoService _service;

    public PlatoController(IPlatoService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var plato = await _service.GetByIdAsync(id);
        return plato is null ? NotFound() : Ok(plato);
    }

    [HttpGet("categoria/{nombre}")]
    public async Task<IActionResult> GetByCategoria(string nombre) =>
        Ok(await _service.GetByCategoriaAsync(nombre));

    [HttpGet("precio")]
    public async Task<IActionResult> GetByPrecioRange([FromQuery] decimal min, [FromQuery] decimal max) =>
        Ok(await _service.GetByPrecioRangeAsync(min, max));

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Plato plato)
    {
        var created = await _service.CreateAsync(plato);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Plato plato)
    {
        await _service.UpdateAsync(id, plato);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}