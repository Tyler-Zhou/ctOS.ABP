using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ctOS.Pages;

[Collection(ctOSTestConsts.CollectionDefinitionName)]
public class Index_Tests : ctOSWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
