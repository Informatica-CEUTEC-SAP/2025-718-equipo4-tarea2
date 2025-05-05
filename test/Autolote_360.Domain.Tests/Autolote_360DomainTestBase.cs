using Volo.Abp.Modularity;

namespace Autolote_360;

/* Inherit from this class for your domain layer tests. */
public abstract class Autolote_360DomainTestBase<TStartupModule> : Autolote_360TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
