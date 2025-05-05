using Autolote_360.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Autolote_360.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Autolote_360Controller : AbpControllerBase
{
    protected Autolote_360Controller()
    {
        LocalizationResource = typeof(Autolote_360Resource);
    }
}
