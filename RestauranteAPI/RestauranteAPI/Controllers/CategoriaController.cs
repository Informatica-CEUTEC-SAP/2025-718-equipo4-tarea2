using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    private readonly ICategoriaService _service;

    public CategoriaController(ICategoriaService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _service.ObtenerCategoriasAsync()); // ✅ método correcto

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Categoria categoria)
    {
        var created = await _service.CrearCategoriaAsync(categoria); // ✅ método correcto
        return CreatedAtAction(nameof(GetAll), new { id = created.Id }, created);
    }
}