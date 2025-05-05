using System.Threading.Tasks;

namespace Autolote_360.Data;

public interface IAutolote_360DbSchemaMigrator
{
    Task MigrateAsync();
}
