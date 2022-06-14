using ctOS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ctOS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ctOSController : AbpControllerBase
{
    protected ctOSController()
    {
        LocalizationResource = typeof(ctOSResource);
    }
}
