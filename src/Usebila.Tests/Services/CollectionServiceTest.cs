using System.Threading.Tasks;
using Usebila.Models.Collections;

namespace Usebila.Tests.Services;

public class CollectionServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Retrieve_Works()
    {
        var collection = await this.client.Collections.Retrieve(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        collection.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var collections = await this.client.Collections.List(
            new(),
            TestContext.Current.CancellationToken
        );
        collections.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task GetStatusByReference_Works()
    {
        var response = await this.client.Collections.GetStatusByReference(
            "collection-001",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task InitiateMobileMoneyCollection_Works()
    {
        var response = await this.client.Collections.InitiateMobileMoneyCollection(
            new()
            {
                Amount = 100.5,
                Country = Country.Zm,
                Operator = Operator.Airtel,
                Phone = "0977433571",
                Reference = "collection-001",
                WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
