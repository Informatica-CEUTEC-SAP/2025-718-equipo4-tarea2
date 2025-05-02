using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Controllers;

[ApiController]
[Route("api/categorias")]
public class Categorias : ControllerBase
{
    private readonly ICategoriaService _service;

    public Categorias(ICategoriaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _service.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create(Categoria categoria) =>
        Ok(await _service.CreateAsync(categoria));
}