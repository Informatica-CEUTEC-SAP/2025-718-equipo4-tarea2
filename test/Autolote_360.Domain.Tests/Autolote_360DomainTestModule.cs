using Volo.Abp.Modularity;

namespace Autolote_360;

[DependsOn(
    typeof(Autolote_360DomainModule),
    typeof(Autolote_360TestBaseModule)
)]
public class Autolote_360DomainTestModule : AbpModule
{

}
