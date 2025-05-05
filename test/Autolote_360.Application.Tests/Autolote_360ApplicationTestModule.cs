using Volo.Abp.Modularity;

namespace Autolote_360;

[DependsOn(
    typeof(Autolote_360ApplicationModule),
    typeof(Autolote_360DomainTestModule)
)]
public class Autolote_360ApplicationTestModule : AbpModule
{

}
