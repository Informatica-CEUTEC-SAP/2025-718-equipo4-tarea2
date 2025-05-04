using Microsoft.AspNetCore.Mvc.Testing;

namespace RestauranteAPI.Tests.Factories
{
    // Usa Program como punto de entrada en lugar de Startup
    public class WebApplicationFactoryTestFixture : WebApplicationFactory<Program>
    {
    }
}