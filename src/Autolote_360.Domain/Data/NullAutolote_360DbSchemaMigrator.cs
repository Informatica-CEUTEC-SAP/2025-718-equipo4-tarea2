using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Autolote_360.Data;

/* This is used if database provider does't define
 * IAutolote_360DbSchemaMigrator implementation.
 */
public class NullAutolote_360DbSchemaMigrator : IAutolote_360DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
