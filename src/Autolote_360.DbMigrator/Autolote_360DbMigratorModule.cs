using Autolote_360.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Autolote_360.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Autolote_360EntityFrameworkCoreModule),
    typeof(Autolote_360ApplicationContractsModule)
)]
public class Autolote_360DbMigratorModule : AbpModule
{
}
