using ctOS.MongoDB;
using Volo.Abp.Modularity;

namespace ctOS;

[DependsOn(
    typeof(ctOSMongoDbTestModule)
    )]
public class ctOSDomainTestModule : AbpModule
{

}
