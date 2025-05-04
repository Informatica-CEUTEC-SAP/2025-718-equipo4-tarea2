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
            response.EnsureSuccessStatusCode(); // Asegura que la respuesta fue exitosa (código 200)
        }

        [Fact]
        public async Task CreateCategoria_ReturnsCreatedStatusCode()
        {
            var newCategoria = new Categoria { Nombre = "Bebidas" };
            var content = new StringContent(JsonConvert.SerializeObject(newCategoria), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/categoria", content);
            response.EnsureSuccessStatusCode(); // Asegura que la respuesta fue exitosa (código 201)
        }
    }
}