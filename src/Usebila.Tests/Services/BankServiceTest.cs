using System.Threading.Tasks;

namespace Usebila.Tests.Services;

public class BankServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var banks = await this.client.Banks.List(new(), TestContext.Current.CancellationToken);
        banks.Validate();
    }
}
