using System.Threading.Tasks;
using Bila.Models.TransferRecipients;

namespace Bila.Tests.Services;

public class TransferRecipientServiceTest : TestBase
{
    [Fact(Skip = "Mock server tests are disabled")]
    public async Task Retrieve_Works()
    {
        var transferRecipient = await this.client.TransferRecipients.Retrieve(
            "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            new(),
            TestContext.Current.CancellationToken
        );
        transferRecipient.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task List_Works()
    {
        var transferRecipients = await this.client.TransferRecipients.List(
            new(),
            TestContext.Current.CancellationToken
        );
        transferRecipients.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task CreateBankAccount_Works()
    {
        var response = await this.client.TransferRecipients.CreateBankAccount(
            new() { AccountNumber = "1234567890", BankID = "bank-001" },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Mock server tests are disabled")]
    public async Task CreateMobileMoney_Works()
    {
        var response = await this.client.TransferRecipients.CreateMobileMoney(
            new()
            {
                Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
                Operator = Operator.Airtel,
                Phone = "0977433571",
            },
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
