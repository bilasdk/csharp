using System;
using Usebila.Models.Transfers;

namespace Usebila.Tests.Models.Transfers;

public class TransferGetStatusByReferenceParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new TransferGetStatusByReferenceParams { Reference = "transfer-001" };

        string expectedReference = "transfer-001";

        Assert.Equal(expectedReference, parameters.Reference);
    }

    [Fact]
    public void Url_Works()
    {
        TransferGetStatusByReferenceParams parameters = new() { Reference = "transfer-001" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/transfers/status/transfer-001"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new TransferGetStatusByReferenceParams { Reference = "transfer-001" };

        TransferGetStatusByReferenceParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
