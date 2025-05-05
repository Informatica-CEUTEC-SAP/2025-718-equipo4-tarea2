using Autolote_360.Samples;
using Xunit;

namespace Autolote_360.EntityFrameworkCore.Domains;

[Collection(Autolote_360TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Autolote_360EntityFrameworkCoreTestModule>
{

}
