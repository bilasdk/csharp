using Bila;
using Bila.Core;
using Bila.Models.Collections;

namespace Bila.Examples;

/// <summary>
/// Collections examples
///
/// To demonstrate how to make collects
/// via mobile money.
/// </summary>
static class CollectionsExample
{
    const string CollectionId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string WalletId = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
    const string Reference = "collection-001";

    public static async Task Run()
    {
        BilaClient client = new()
        {
            ApiKey = Environment.GetEnvironmentVariable("BILA_API_KEY") ?? "sk_test_your_api_key_here",
            BaseUrl = EnvironmentUrl.Sandbox,
        };

        /********************************************
         * Retrieve collection
         *********************************************/
        CollectionRetrieveResponse collection = await client.Collections.Retrieve(CollectionId);
        Console.WriteLine("retrieve: {0}", collection);

        /********************************************
         * List collections
         *********************************************/
        CollectionListParams listParams = new()
        {
            AccountID = WalletId,
            StartDate = "2024-01-01T00:00:00Z",
            EndDate = "2024-12-31T23:59:59Z",
            Page = 1,
            PerPage = 50,
            Status = Status.Pending,
        };

        CollectionListResponse collections = await client.Collections.List(listParams);
        Console.WriteLine("list: {0}", collections);

        /********************************************
         * Get collection status by reference
         *********************************************/
        CollectionGetStatusByReferenceResponse status =
            await client.Collections.GetStatusByReference(Reference);
        Console.WriteLine("getStatusByReference: {0}", status);

        /********************************************
         * Initiate mobile money collection
         *********************************************/
        CollectionInitiateMobileMoneyCollectionParams initiateParams = new()
        {
            Amount = 100.5,
            Country = Country.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = Reference,
            WalletID = WalletId,
            Bearer = Bearer.Customer,
            CustomerName = "John Doe",
            Narration = "Payment for subscription",
        };

        CollectionInitiateMobileMoneyCollectionResponse initiated =
            await client.Collections.InitiateMobileMoneyCollection(initiateParams);
        Console.WriteLine("initiateMobileMoneyCollection: {0}", initiated);
    }
}
