using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace ctOS.MongoDB;

[DependsOn(
    typeof(ctOSTestBaseModule),
    typeof(ctOSMongoDbModule)
    )]
public class ctOSMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = ctOSMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
