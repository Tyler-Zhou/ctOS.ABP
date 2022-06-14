using Volo.Abp.Modularity;

namespace ctOS;

[DependsOn(
    typeof(ctOSApplicationModule),
    typeof(ctOSDomainTestModule)
    )]
public class ctOSApplicationTestModule : AbpModule
{

}
