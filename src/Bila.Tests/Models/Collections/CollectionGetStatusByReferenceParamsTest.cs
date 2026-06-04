using System;
using Bila.Models.Collections;

namespace Bila.Tests.Models.Collections;

public class CollectionGetStatusByReferenceParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CollectionGetStatusByReferenceParams { Reference = "collection-001" };

        string expectedReference = "collection-001";

        Assert.Equal(expectedReference, parameters.Reference);
    }

    [Fact]
    public void Url_Works()
    {
        CollectionGetStatusByReferenceParams parameters = new() { Reference = "collection-001" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/collections/status/collection-001"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new CollectionGetStatusByReferenceParams { Reference = "collection-001" };

        CollectionGetStatusByReferenceParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
