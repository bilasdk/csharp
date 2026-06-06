using Bila;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Examples;

/// <summary>
/// Accounts examples
///
/// To demonstrate how to retrieve accounts,
/// list accounts, and check balances.
/// </summary>
static class AccountsExample
{
    const string AccountId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey = Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Retrieve account
         *********************************************/
        AccountRetrieveResponse account = await client.Accounts.Retrieve(AccountId);
        Console.WriteLine("retrieve: {0}", account);

        /********************************************
         * List accounts
         *********************************************/
        AccountListParams listParams = new() { Page = 1, PerPage = 50 };

        AccountListResponse accounts = await client.Accounts.List(listParams);
        Console.WriteLine("list: {0}", accounts);

        /********************************************
         * Get account balance
         *********************************************/
        AccountGetBalanceResponse balance = await client.Accounts.GetBalance(AccountId);
        Console.WriteLine("getBalance: {0}", balance);
    }
}
