using Microsoft.AspNetCore.Mvc.Testing;
using RestauranteAPI.Domain.Entities;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace RestauranteAPI.Tests.Controllers
{
    public class CategoriasControllerTests : IClassFixture<WebApplicationFactory<RestauranteAPI.Startup>>
    {
        private readonly HttpClient _client;

        public CategoriasControllerTests(WebApplicationFactory<RestauranteAPI.Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAllCategorias_ReturnsOkResponse()
        {
            var response = await _client.GetAsync("/api/categorias");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task CreateCategoria_ReturnsCreatedResponse()
        {
            var categoria = new Categoria { Nombre = "Entradas" };
            var response = await _client.PostAsJsonAsync("/api/categorias", categoria);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
