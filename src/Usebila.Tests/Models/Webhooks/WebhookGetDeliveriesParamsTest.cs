using System;
using Usebila.Models.Webhooks;

namespace Usebila.Tests.Models.Webhooks;

public class WebhookGetDeliveriesParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WebhookGetDeliveriesParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2026-04-30T23:59:59.999Z",
            EventType = "payment.completed",
            Page = 1,
            PerPage = 20,
            StartDate = "2026-04-01T00:00:00.000Z",
            Status = "DELIVERED",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        string expectedEndDate = "2026-04-30T23:59:59.999Z";
        string expectedEventType = "payment.completed";
        double expectedPage = 1;
        double expectedPerPage = 20;
        string expectedStartDate = "2026-04-01T00:00:00.000Z";
        string expectedStatus = "DELIVERED";

        Assert.Equal(expectedID, parameters.ID);
        Assert.Equal(expectedEndDate, parameters.EndDate);
        Assert.Equal(expectedEventType, parameters.EventType);
        Assert.Equal(expectedPage, parameters.Page);
        Assert.Equal(expectedPerPage, parameters.PerPage);
        Assert.Equal(expectedStartDate, parameters.StartDate);
        Assert.Equal(expectedStatus, parameters.Status);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new WebhookGetDeliveriesParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        Assert.Null(parameters.EndDate);
        Assert.False(parameters.RawQueryData.ContainsKey("endDate"));
        Assert.Null(parameters.EventType);
        Assert.False(parameters.RawQueryData.ContainsKey("eventType"));
        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
        Assert.Null(parameters.StartDate);
        Assert.False(parameters.RawQueryData.ContainsKey("startDate"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new WebhookGetDeliveriesParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",

            // Null should be interpreted as omitted for these properties
            EndDate = null,
            EventType = null,
            Page = null,
            PerPage = null,
            StartDate = null,
            Status = null,
        };

        Assert.Null(parameters.EndDate);
        Assert.False(parameters.RawQueryData.ContainsKey("endDate"));
        Assert.Null(parameters.EventType);
        Assert.False(parameters.RawQueryData.ContainsKey("eventType"));
        Assert.Null(parameters.Page);
        Assert.False(parameters.RawQueryData.ContainsKey("page"));
        Assert.Null(parameters.PerPage);
        Assert.False(parameters.RawQueryData.ContainsKey("perPage"));
        Assert.Null(parameters.StartDate);
        Assert.False(parameters.RawQueryData.ContainsKey("startDate"));
        Assert.Null(parameters.Status);
        Assert.False(parameters.RawQueryData.ContainsKey("status"));
    }

    [Fact]
    public void Url_Works()
    {
        WebhookGetDeliveriesParams parameters = new()
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2026-04-30T23:59:59.999Z",
            EventType = "payment.completed",
            Page = 1,
            PerPage = 20,
            StartDate = "2026-04-01T00:00:00.000Z",
            Status = "DELIVERED",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri(
                    "https://api.usebila.com/api/v1/bila/webhooks/68f11209-451f-4a15-bfcd-d916eb8b09f4/deliveries?endDate=2026-04-30T23%3a59%3a59.999Z&eventType=payment.completed&page=1&perPage=20&startDate=2026-04-01T00%3a00%3a00.000Z&status=DELIVERED"
                ),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new WebhookGetDeliveriesParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            EndDate = "2026-04-30T23:59:59.999Z",
            EventType = "payment.completed",
            Page = 1,
            PerPage = 20,
            StartDate = "2026-04-01T00:00:00.000Z",
            Status = "DELIVERED",
        };

        WebhookGetDeliveriesParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}
