using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ctOS.Web;

[Dependency(ReplaceServices = true)]
public class ctOSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ctOS";
}
