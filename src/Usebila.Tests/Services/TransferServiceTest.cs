using System.Threading.Tasks;
using Usebila.Models.Transfers;

namespace Usebila.Tests.Services;

public class TransferServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Retrieve_Works()
    {
        var transfer = await this.client.Transfers.Retrieve(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        transfer.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var transfers = await this.client.Transfers.List(
            new(),
            TestContext.Current.CancellationToken
        );
        transfers.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task GetStatusByReference_Works()
    {
        var response = await this.client.Transfers.GetStatusByReference(
            "transfer-001",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task InitiateBankTransfer_Works()
    {
        var response = await this.client.Transfers.InitiateBankTransfer(
            new()
            {
                AccountID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
                Amount = 1000,
                Reference = "transfer-001",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task InitiateMobileMoneyTransfer_Works()
    {
        var response = await this.client.Transfers.InitiateMobileMoneyTransfer(
            new()
            {
                Amount = 250,
                Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
                Operator = Operator.Airtel,
                Phone = "0977433571",
                Reference = "mobile-transfer-001",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
