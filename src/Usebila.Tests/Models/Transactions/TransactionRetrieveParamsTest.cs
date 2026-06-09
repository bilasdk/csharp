using System;
using Usebila.Models.Transactions;

namespace Usebila.Tests.Models.Transactions;

public class TransactionRetrieveParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TransactionRetrieveParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

        Assert.Equal(expectedID, parameters.ID);
    }

    [Fact]
    public void Url_Works()
    {
        TransactionRetrieveParams parameters = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/transactions/68f11209-451f-4a15-bfcd-d916eb8b09f4"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TransactionRetrieveParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        TransactionRetrieveParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
