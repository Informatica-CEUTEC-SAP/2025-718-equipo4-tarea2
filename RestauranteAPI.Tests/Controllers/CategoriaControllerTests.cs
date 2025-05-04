using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Tests.Factories;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestauranteAPI.Tests.Controllers
{
    public class CategoriaControllerTests : IClassFixture<WebApplicationFactoryTestFixture>
    {
        private readonly HttpClient _client;

        public CategoriaControllerTests(WebApplicationFactoryTestFixture factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAllCategorias_ReturnsOkStatusCode()
        {
            var response = await _client.GetAsync("/api/categoria");
            response.EnsureSuccessStatusCode(); // Código 200
        }

        [Fact]
        public async Task CreateCategoria_ReturnsCreatedCategoria()
        {
            var newCategoria = new Categoria { Nombre = "Entradas" };
            var json = JsonConvert.SerializeObject(newCategoria);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/categoria", content);
            response.EnsureSuccessStatusCode(); // Código 201

            var responseString = await response.Content.ReadAsStringAsync();
            var created = JsonConvert.DeserializeObject<Categoria>(responseString);

            Assert.NotNull(created);
            Assert.Equal("Entradas", created.Nombre);
        }
    }
}