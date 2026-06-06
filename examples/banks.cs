using Bila;
using Bila.Core;
using Bila.Models.Banks;

namespace Bila.Examples;

/// <summary>
/// Banks examples
///
/// To demonstrate how to list supported banks
/// and financial institutions.
/// </summary>
static class BanksExample
{
    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey = Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        BankListParams listParams = new() { Country = "zm" };

        BankListResponse banks = await client.Banks.List(listParams);
        Console.WriteLine("list: {0}", banks);
    }
}
