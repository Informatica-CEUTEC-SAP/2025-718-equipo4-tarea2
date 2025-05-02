using Microsoft.AspNetCore.Mvc.Testing;
using RestauranteAPI.Domain.Entities;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace RestauranteAPI.Tests.Controllers
{
    public class PlatosControllerTests : IClassFixture<WebApplicationFactory<RestauranteAPI.Startup>>
    {
        private readonly HttpClient _client;

        public PlatosControllerTests(WebApplicationFactory<RestauranteAPI.Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAllPlatos_ReturnsOkResponse()
        {
            var response = await _client.GetAsync("/api/platos");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetPlatoById_ReturnsCorrectPlato()
        {
            var response = await _client.GetAsync("/api/platos/1");

            response.EnsureSuccessStatusCode();
            var plato = await response.Content.ReadAsAsync<Plato>();
            Assert.Equal(1, plato.Id);
        }

        [Fact]
        public async Task CreatePlato_ReturnsCreatedResponse()
        {
            var plato = new Plato { Nombre = "Pizza", Descripcion = "Deliciosa pizza", Precio = 10.99m, CategoriaId = 1 };
            var response = await _client.PostAsJsonAsync("/api/platos", plato);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task UpdatePlato_ReturnsNoContentResponse()
        {
            var plato = new Plato { Id = 1, Nombre = "Pizza", Descripcion = "Pizza actualizada", Precio = 12.99m, CategoriaId = 1 };
            var response = await _client.PutAsJsonAsync("/api/platos/1", plato);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Fact]
        public async Task DeletePlato_ReturnsNoContentResponse()
        {
            var response = await _client.DeleteAsync("/api/platos/1");

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }
    }
}
