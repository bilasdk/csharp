using System;
using System.Collections.Generic;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Webhooks;

namespace Usebila.Tests.Models.Webhooks;

public class WebhookUpdateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WebhookUpdateParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Events =
            [
                WebhookUpdateParamsEvent.PaymentCompleted,
                WebhookUpdateParamsEvent.CollectionCompleted,
            ],
            IsActive = true,
            UrlValue = "https://example.com/webhooks",
        };

        string expectedID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        List<ApiEnum<string, WebhookUpdateParamsEvent>> expectedEvents =
        [
            WebhookUpdateParamsEvent.PaymentCompleted,
            WebhookUpdateParamsEvent.CollectionCompleted,
        ];
        bool expectedIsActive = true;
        string expectedUrlValue = "https://example.com/webhooks";

        Assert.Equal(expectedID, parameters.ID);
        Assert.NotNull(parameters.Events);
        Assert.Equal(expectedEvents.Count, parameters.Events.Count);
        for (int i = 0; i < expectedEvents.Count; i++)
        {
            Assert.Equal(expectedEvents[i], parameters.Events[i]);
        }
        Assert.Equal(expectedIsActive, parameters.IsActive);
        Assert.Equal(expectedUrlValue, parameters.UrlValue);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new WebhookUpdateParams { ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4" };

        Assert.Null(parameters.Events);
        Assert.False(parameters.RawBodyData.ContainsKey("events"));
        Assert.Null(parameters.IsActive);
        Assert.False(parameters.RawBodyData.ContainsKey("isActive"));
        Assert.Null(parameters.UrlValue);
        Assert.False(parameters.RawBodyData.ContainsKey("url"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new WebhookUpdateParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",

            // Null should be interpreted as omitted for these properties
            Events = null,
            IsActive = null,
            UrlValue = null,
        };

        Assert.Null(parameters.Events);
        Assert.False(parameters.RawBodyData.ContainsKey("events"));
        Assert.Null(parameters.IsActive);
        Assert.False(parameters.RawBodyData.ContainsKey("isActive"));
        Assert.Null(parameters.UrlValue);
        Assert.False(parameters.RawBodyData.ContainsKey("url"));
    }

    [Fact]
    public void Url_Works()
    {
        WebhookUpdateParams parameters = new() { ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4" };

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
        var parameters = new WebhookUpdateParams
        {
            ID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Events =
            [
                WebhookUpdateParamsEvent.PaymentCompleted,
                WebhookUpdateParamsEvent.CollectionCompleted,
            ],
            IsActive = true,
            UrlValue = "https://example.com/webhooks",
        };

        WebhookUpdateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class WebhookUpdateParamsEventTest : TestBase
{
    [Theory]
    [InlineData(WebhookUpdateParamsEvent.OrderCreated)]
    [InlineData(WebhookUpdateParamsEvent.OrderPaid)]
    [InlineData(WebhookUpdateParamsEvent.OrderCancelled)]
    [InlineData(WebhookUpdateParamsEvent.StockLow)]
    [InlineData(WebhookUpdateParamsEvent.PaymentCreated)]
    [InlineData(WebhookUpdateParamsEvent.PaymentCompleted)]
    [InlineData(WebhookUpdateParamsEvent.PaymentFailed)]
    [InlineData(WebhookUpdateParamsEvent.CollectionPending)]
    [InlineData(WebhookUpdateParamsEvent.CollectionCompleted)]
    [InlineData(WebhookUpdateParamsEvent.CollectionFailed)]
    [InlineData(WebhookUpdateParamsEvent.WithdrawalCreated)]
    [InlineData(WebhookUpdateParamsEvent.WithdrawalCompleted)]
    [InlineData(WebhookUpdateParamsEvent.WithdrawalFailed)]
    [InlineData(WebhookUpdateParamsEvent.TransactionUpdated)]
    [InlineData(WebhookUpdateParamsEvent.TransferPending)]
    [InlineData(WebhookUpdateParamsEvent.TransferCompleted)]
    [InlineData(WebhookUpdateParamsEvent.TransferFailed)]
    [InlineData(WebhookUpdateParamsEvent.SettlementCompleted)]
    public void Validation_Works(WebhookUpdateParamsEvent rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, WebhookUpdateParamsEvent> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, WebhookUpdateParamsEvent>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(WebhookUpdateParamsEvent.OrderCreated)]
    [InlineData(WebhookUpdateParamsEvent.OrderPaid)]
    [InlineData(WebhookUpdateParamsEvent.OrderCancelled)]
    [InlineData(WebhookUpdateParamsEvent.StockLow)]
    [InlineData(WebhookUpdateParamsEvent.PaymentCreated)]
    [InlineData(WebhookUpdateParamsEvent.PaymentCompleted)]
    [InlineData(WebhookUpdateParamsEvent.PaymentFailed)]
    [InlineData(WebhookUpdateParamsEvent.CollectionPending)]
    [InlineData(WebhookUpdateParamsEvent.CollectionCompleted)]
    [InlineData(WebhookUpdateParamsEvent.CollectionFailed)]
    [InlineData(WebhookUpdateParamsEvent.WithdrawalCreated)]
    [InlineData(WebhookUpdateParamsEvent.WithdrawalCompleted)]
    [InlineData(WebhookUpdateParamsEvent.WithdrawalFailed)]
    [InlineData(WebhookUpdateParamsEvent.TransactionUpdated)]
    [InlineData(WebhookUpdateParamsEvent.TransferPending)]
    [InlineData(WebhookUpdateParamsEvent.TransferCompleted)]
    [InlineData(WebhookUpdateParamsEvent.TransferFailed)]
    [InlineData(WebhookUpdateParamsEvent.SettlementCompleted)]
    public void SerializationRoundtrip_Works(WebhookUpdateParamsEvent rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, WebhookUpdateParamsEvent> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, WebhookUpdateParamsEvent>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, WebhookUpdateParamsEvent>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, WebhookUpdateParamsEvent>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
