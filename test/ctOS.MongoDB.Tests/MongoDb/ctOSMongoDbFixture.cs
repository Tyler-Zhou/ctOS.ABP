using System;
using Mongo2Go;

namespace ctOS.MongoDB;

public class ctOSMongoDbFixture : IDisposable
{
    private static readonly MongoDbRunner MongoDbRunner;
    public static readonly string ConnectionString;

    static ctOSMongoDbFixture()
    {
        MongoDbRunner = MongoDbRunner.Start(singleNodeReplSet: true, singleNodeReplSetWaitTimeout: 20);
        ConnectionString = MongoDbRunner.ConnectionString;
    }

    public void Dispose()
    {
        MongoDbRunner?.Dispose();
    }
}
