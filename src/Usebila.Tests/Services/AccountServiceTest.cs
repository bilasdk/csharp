using System.Threading.Tasks;

namespace Usebila.Tests.Services;

public class AccountServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Retrieve_Works()
    {
        var account = await this.client.Accounts.Retrieve(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        account.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var accounts = await this.client.Accounts.List(
            new(),
            TestContext.Current.CancellationToken
        );
        accounts.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task GetBalance_Works()
    {
        var response = await this.client.Accounts.GetBalance(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
