using System.Threading.Tasks;

namespace ctOS.Data;

public interface IctOSDbSchemaMigrator
{
    Task MigrateAsync();
}
