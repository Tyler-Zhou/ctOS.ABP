using ctOS.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ctOS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ctOSMongoDbModule),
    typeof(ctOSApplicationContractsModule)
    )]
public class ctOSDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
