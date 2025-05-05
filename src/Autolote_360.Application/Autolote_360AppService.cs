using Autolote_360.Localization;
using Volo.Abp.Application.Services;

namespace Autolote_360;

/* Inherit your application services from this class.
 */
public abstract class Autolote_360AppService : ApplicationService
{
    protected Autolote_360AppService()
    {
        LocalizationResource = typeof(Autolote_360Resource);
    }
}
