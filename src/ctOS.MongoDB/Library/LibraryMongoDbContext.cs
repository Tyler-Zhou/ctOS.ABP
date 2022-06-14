using MongoDB.Driver;
using Volo.Abp.MongoDB;

namespace ctOS.Library
{
    public class LibraryMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<Book> Books => Collection<Book>();
        //...
    }
}
