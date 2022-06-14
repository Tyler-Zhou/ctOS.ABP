using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ctOS.Data;

/* This is used if database provider does't define
 * IctOSDbSchemaMigrator implementation.
 */
public class NullctOSDbSchemaMigrator : IctOSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
