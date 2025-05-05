using Microsoft.Extensions.Localization;
using Autolote_360.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Autolote_360;

[Dependency(ReplaceServices = true)]
public class Autolote_360BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Autolote_360Resource> _localizer;

    public Autolote_360BrandingProvider(IStringLocalizer<Autolote_360Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
