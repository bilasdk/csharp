using Bila;
using Bila.Core;
using Bila.Models.Transfers;

namespace Bila.Examples;

/// <summary>
/// Transfers examples
///
/// To demonstrate how to send payouts via
/// bank transfer and mobile money.
/// </summary>
static class TransfersExample
{
    const string TransferId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string AccountId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string TransferRecipientId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string WalletId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string BankReference = "transfer-001";
    const string MobileReference = "mobile-transfer-001";

    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey = Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Retrieve transfer
         *********************************************/
        TransferRetrieveResponse transfer = await client.Transfers.Retrieve(TransferId);
        Console.WriteLine("retrieve: {0}", transfer);

        /********************************************
         * List transfers
         *********************************************/
        TransferListParams listParams = new()
        {
            AccountID = AccountId,
            StartDate = "2024-01-01T00:00:00Z",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            Status = Status.Pending,
            Type = Bila.Models.Transfers.Type.BankAccount,
        };

        TransferListResponse transfers = await client.Transfers.List(listParams);
        Console.WriteLine("list: {0}", transfers);

        /********************************************
         * Get transfer status by reference
         *********************************************/
        TransferGetStatusByReferenceResponse status =
            await client.Transfers.GetStatusByReference(BankReference);
        Console.WriteLine("getStatusByReference: {0}", status);

        /********************************************
         * Initiate bank transfer
         *********************************************/
        TransferInitiateBankTransferParams bankParams = new()
        {
            AccountID = AccountId,
            Amount = 1000,
            Reference = BankReference,
            AccountNumber = "1234567890",
            BankID = "bank-001",
            Country = Country.Zm,
            Narration = "Payment for services",
            RecipientName = "Jane Doe",
            TransferRecipientID = TransferRecipientId,
            WalletID = WalletId,
        };

        TransferInitiateBankTransferResponse bankTransfer =
            await client.Transfers.InitiateBankTransfer(bankParams);
        Console.WriteLine("initiateBankTransfer: {0}", bankTransfer);

        /********************************************
         * Initiate mobile money transfer
         *********************************************/
        TransferInitiateMobileMoneyTransferParams mobileParams = new()
        {
            Amount = 250,
            Country = TransferInitiateMobileMoneyTransferParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = MobileReference,
            Narration = "Mobile money payout",
            RecipientName = "Jane Doe",
            WalletID = WalletId,
        };

        TransferInitiateMobileMoneyTransferResponse mobileTransfer =
            await client.Transfers.InitiateMobileMoneyTransfer(mobileParams);
        Console.WriteLine("initiateMobileMoneyTransfer: {0}", mobileTransfer);
    }
}
