using System;
using System.Collections.Generic;
using System.Text;
using ctOS.Localization;
using Volo.Abp.Application.Services;

namespace ctOS;

/* Inherit your application services from this class.
 */
public abstract class ctOSAppService : ApplicationService
{
    protected ctOSAppService()
    {
        LocalizationResource = typeof(ctOSResource);
    }
}
