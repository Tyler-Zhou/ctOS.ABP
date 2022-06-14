using ctOS.MongoDB;
using Xunit;

namespace ctOS;

[CollectionDefinition(ctOSTestConsts.CollectionDefinitionName)]
public class ctOSApplicationCollection : ctOSMongoDbCollectionFixtureBase
{

}
