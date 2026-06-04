using System;
using Bila.Models.Webhooks;

namespace Bila.Tests.Models.Webhooks;

public class WebhookDeactivateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WebhookDeactivateParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";

        Assert.Equal(expectedID, parameters.ID);
    }

    [Fact]
    public void Url_Works()
    {
        WebhookDeactivateParams parameters = new() { ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4" };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/webhooks/68f11209-451f-4a15-bfcd-d916eb8b09f4"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new WebhookDeactivateParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        WebhookDeactivateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
