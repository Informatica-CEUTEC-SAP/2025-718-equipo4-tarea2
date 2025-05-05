using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Autolote_360.Data;
using Volo.Abp.DependencyInjection;

namespace Autolote_360.EntityFrameworkCore;

public class EntityFrameworkCoreAutolote_360DbSchemaMigrator
    : IAutolote_360DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAutolote_360DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Autolote_360DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Autolote_360DbContext>()
            .Database
            .MigrateAsync();
    }
}
