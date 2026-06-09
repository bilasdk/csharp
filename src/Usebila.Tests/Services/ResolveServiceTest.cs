using System.Threading.Tasks;
using Usebila.Models.Resolve;

namespace Usebila.Tests.Services;

public class ResolveServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task BankAccount_Works()
    {
        var response = await this.client.Resolve.BankAccount(
            new() { AccountNumber = "1234567890", BankID = "bank-001" },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task MobileMoney_Works()
    {
        var response = await this.client.Resolve.MobileMoney(
            new()
            {
                Country = ResolveMobileMoneyParamsCountry.Zm,
                Operator = Operator.Airtel,
                Phone = "0977433571",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
