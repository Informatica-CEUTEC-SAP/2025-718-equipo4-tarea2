using Moq;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Domain.Entities;
using System.Threading.Tasks;
using Xunit;

namespace RestauranteAPI.Tests.Services
{
    public class CategoriaServiceTests
    {
        private readonly Mock<ICategoriaRepository> _categoriaRepositoryMock;
        private readonly ICategoriaService _categoriaService;

        public CategoriaServiceTests()
        {
            _categoriaRepositoryMock = new Mock<ICategoriaRepository>();
            _categoriaService = new CategoriaService(_categoriaRepositoryMock.Object);
        }

        [Fact]
        public async Task CrearCategoria_ReturnsCategoria()
        {
            var newCategoria = new Categoria { Nombre = "Bebidas" };

            _categoriaRepositoryMock
                .Setup(repo => repo.CreateAsync(It.IsAny<Categoria>()))
                .ReturnsAsync(newCategoria);

            var result = await _categoriaService.CrearCategoriaAsync(newCategoria);

            Assert.NotNull(result);
            Assert.Equal("Bebidas", result.Nombre);
        }
    }
}