using Bila;
using Bila.Core;
using Bila.Models.Resolve;

namespace Bila.Examples;

/// <summary>
/// Resolve examples
///
/// To demonstrate how to verify bank account
/// and mobile money account details.
/// </summary>
static class ResolveExample
{
    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey = Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Resolve bank account
         *********************************************/
        ResolveBankAccountParams resolveBankParams = new()
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",
            Country = Country.Zm,
        };

        ResolveBankAccountResponse bankAccount =
            await client.Resolve.BankAccount(resolveBankParams);
        Console.WriteLine("bankAccount: {0}", bankAccount);

        /********************************************
         * Resolve mobile money
         *********************************************/
        ResolveMobileMoneyParams resolveMobileParams = new()
        {
            Country = ResolveMobileMoneyParamsCountry.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
        };

        ResolveMobileMoneyResponse mobileMoney =
            await client.Resolve.MobileMoney(resolveMobileParams);
        Console.WriteLine("mobileMoney: {0}", mobileMoney);
    }
}
