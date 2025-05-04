using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using System.Net.Http;

namespace RestauranteAPI.Tests.Factories
{
    public class WebApplicationFactoryTestFixture : WebApplicationFactory<RestauranteAPI.Startup>
    {
        public HttpClient CreateClient()
        {
            return base.CreateClient();
        }
    }
}