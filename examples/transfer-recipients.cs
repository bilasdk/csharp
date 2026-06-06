using Bila;
using Bila.Core;
using Bila.Models.TransferRecipients;

namespace Bila.Examples;

/// <summary>
/// Transfer recipients examples
///
/// To demonstrate how to manage payout recipients
/// for bank accounts and mobile money.
/// </summary>
static class TransferRecipientsExample
{
    const string RecipientId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey =
                Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Retrieve transfer recipient
         *********************************************/
        TransferRecipientRetrieveResponse recipient = await client.TransferRecipients.Retrieve(
            RecipientId
        );
        Console.WriteLine("retrieve: {0}", recipient);

        /********************************************
         * List transfer recipients
         *********************************************/
        TransferRecipientListParams listParams = new()
        {
            Page = 1,
            PerPage = 50,
            Type = Bila.Models.TransferRecipients.Type.BankAccount,
        };

        TransferRecipientListResponse recipients = await client.TransferRecipients.List(listParams);
        Console.WriteLine("list: {0}", recipients);

        /********************************************
         * Create bank account recipient
         *********************************************/
        TransferRecipientCreateBankAccountParams bankParams = new()
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",
            AccountName = "John Doe",
            Country = Country.Zm,
        };

        TransferRecipientCreateBankAccountResponse bankRecipient =
            await client.TransferRecipients.CreateBankAccount(bankParams);
        Console.WriteLine("createBankAccount: {0}", bankRecipient);

        /********************************************
         * Create mobile money recipient
         *********************************************/
        TransferRecipientCreateMobileMoneyParams mobileParams = new()
        {
            Country = TransferRecipientCreateMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            AccountName = "John Doe",
        };

        TransferRecipientCreateMobileMoneyResponse mobileRecipient =
            await client.TransferRecipients.CreateMobileMoney(mobileParams);
        Console.WriteLine("createMobileMoney: {0}", mobileRecipient);
    }
}
