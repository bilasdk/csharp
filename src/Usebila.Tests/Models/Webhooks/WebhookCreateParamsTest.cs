using System;
using System.Collections.Generic;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Webhooks;

namespace Usebila.Tests.Models.Webhooks;

public class WebhookCreateParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new WebhookCreateParams
        {
            Events = [Event.PaymentCompleted, Event.WithdrawalCompleted],
            UrlValue = "https://example.com/webhooks",
        };

        List<ApiEnum<string, Event>> expectedEvents =
        [
            Event.PaymentCompleted,
            Event.WithdrawalCompleted,
        ];
        string expectedUrlValue = "https://example.com/webhooks";

        Assert.Equal(expectedEvents.Count, parameters.Events.Count);
        for (int i = 0; i < expectedEvents.Count; i++)
        {
            Assert.Equal(expectedEvents[i], parameters.Events[i]);
        }
        Assert.Equal(expectedUrlValue, parameters.UrlValue);
    }

    [Fact]
    public void Url_Works()
    {
        WebhookCreateParams parameters = new()
        {
            Events = [Event.PaymentCompleted, Event.WithdrawalCompleted],
            UrlValue = "https://example.com/webhooks",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(new Uri("https://api.usebila.com/api/v1/bila/webhooks"), url)
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new WebhookCreateParams
        {
            Events = [Event.PaymentCompleted, Event.WithdrawalCompleted],
            UrlValue = "https://example.com/webhooks",
        };

        WebhookCreateParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class EventTest : TestBase
{
    [Theory]
    [InlineData(Event.OrderCreated)]
    [InlineData(Event.OrderPaid)]
    [InlineData(Event.OrderCancelled)]
    [InlineData(Event.StockLow)]
    [InlineData(Event.PaymentCreated)]
    [InlineData(Event.PaymentCompleted)]
    [InlineData(Event.PaymentFailed)]
    [InlineData(Event.CollectionPending)]
    [InlineData(Event.CollectionCompleted)]
    [InlineData(Event.CollectionFailed)]
    [InlineData(Event.WithdrawalCreated)]
    [InlineData(Event.WithdrawalCompleted)]
    [InlineData(Event.WithdrawalFailed)]
    [InlineData(Event.TransactionUpdated)]
    [InlineData(Event.TransferPending)]
    [InlineData(Event.TransferCompleted)]
    [InlineData(Event.TransferFailed)]
    [InlineData(Event.SettlementCompleted)]
    public void Validation_Works(Event rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Event> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Event>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Event.OrderCreated)]
    [InlineData(Event.OrderPaid)]
    [InlineData(Event.OrderCancelled)]
    [InlineData(Event.StockLow)]
    [InlineData(Event.PaymentCreated)]
    [InlineData(Event.PaymentCompleted)]
    [InlineData(Event.PaymentFailed)]
    [InlineData(Event.CollectionPending)]
    [InlineData(Event.CollectionCompleted)]
    [InlineData(Event.CollectionFailed)]
    [InlineData(Event.WithdrawalCreated)]
    [InlineData(Event.WithdrawalCompleted)]
    [InlineData(Event.WithdrawalFailed)]
    [InlineData(Event.TransactionUpdated)]
    [InlineData(Event.TransferPending)]
    [InlineData(Event.TransferCompleted)]
    [InlineData(Event.TransferFailed)]
    [InlineData(Event.SettlementCompleted)]
    public void SerializationRoundtrip_Works(Event rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Event> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Event>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Event>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Event>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
