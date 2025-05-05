using Autolote_360.Samples;
using Xunit;

namespace Autolote_360.EntityFrameworkCore.Applications;

[Collection(Autolote_360TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Autolote_360EntityFrameworkCoreTestModule>
{

}
