using Autolote_360.Books;
using Xunit;

namespace Autolote_360.EntityFrameworkCore.Applications.Books;

[Collection(Autolote_360TestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<Autolote_360EntityFrameworkCoreTestModule>
{

}