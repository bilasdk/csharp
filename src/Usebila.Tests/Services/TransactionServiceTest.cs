using System.Threading.Tasks;

namespace Usebila.Tests.Services;

public class TransactionServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Retrieve_Works()
    {
        var transaction = await this.client.Transactions.Retrieve(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        transaction.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var transactions = await this.client.Transactions.List(
            new(),
            TestContext.Current.CancellationToken
        );
        transactions.Validate();
    }
}
