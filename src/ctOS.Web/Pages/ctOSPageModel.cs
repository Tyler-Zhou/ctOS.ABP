using ctOS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ctOS.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ctOSPageModel : AbpPageModel
{
    protected ctOSPageModel()
    {
        LocalizationResourceType = typeof(ctOSResource);
    }
}
