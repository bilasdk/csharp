using Bila;
using Bila.Core;
using Bila.Models.Transactions;

namespace Bila.Examples;

/// <summary>
/// Transactions examples
///
/// To demonstrate how to retrieve and list
/// transaction history.
/// </summary>
static class TransactionsExample
{
    const string TransactionId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string AccountId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey =
                Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Retrieve transaction
         *********************************************/
        TransactionRetrieveResponse transaction = await client.Transactions.Retrieve(TransactionId);
        Console.WriteLine("retrieve: {0}", transaction);

        /********************************************
         * List transactions
         *********************************************/
        TransactionListParams listParams = new()
        {
            AccountID = AccountId,
            StartDate = "2024-01-01T00:00:00Z",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            Type = Models.Transactions.Type.Credit,
        };

        TransactionListResponse transactions = await client.Transactions.List(listParams);
        Console.WriteLine("list: {0}", transactions);
    }
}
