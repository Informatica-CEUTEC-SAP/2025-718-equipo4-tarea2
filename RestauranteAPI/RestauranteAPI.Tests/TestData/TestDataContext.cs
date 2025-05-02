using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Tests.TestData
{
    public class TestDataContext
    {
        public static RestauranteDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<RestauranteDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            return new RestauranteDbContext(options);
        }
    }
}