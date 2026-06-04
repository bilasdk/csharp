using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;

namespace Bila.Models.Webhooks;

/// <summary>
/// Create a webhook config
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class WebhookCreateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    /// <summary>
    /// Event types to subscribe to
    /// </summary>
    public required IReadOnlyList<ApiEnum<string, Event>> Events
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullStruct<ImmutableArray<ApiEnum<string, Event>>>(
                "events"
            );
        }
        init
        {
            this._rawBodyData.Set<ImmutableArray<ApiEnum<string, Event>>>(
                "events",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Webhook endpoint URL
    /// </summary>
    public required string UrlValue
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNotNullClass<string>("url");
        }
        init { this._rawBodyData.Set("url", value); }
    }

    public WebhookCreateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookCreateParams(WebhookCreateParams webhookCreateParams)
        : base(webhookCreateParams)
    {
        this._rawBodyData = new(webhookCreateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public WebhookCreateParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookCreateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson{T}.FromRawUnchecked"/>
    public static WebhookCreateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData)
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(
                new Dictionary<string, JsonElement>()
                {
                    ["HeaderData"] = FriendlyJsonPrinter.PrintValue(
                        JsonSerializer.SerializeToElement(this._rawHeaderData.Freeze())
                    ),
                    ["QueryData"] = FriendlyJsonPrinter.PrintValue(
                        JsonSerializer.SerializeToElement(this._rawQueryData.Freeze())
                    ),
                    ["BodyData"] = FriendlyJsonPrinter.PrintValue(this._rawBodyData.Freeze()),
                }
            ),
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(WebhookCreateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(options.BaseUrl.ToString().TrimEnd('/') + "/api/v1/bila/webhooks")
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override HttpContent? BodyContent()
    {
        return new StringContent(
            JsonSerializer.Serialize(this.RawBodyData, ModelBase.SerializerOptions),
            Encoding.UTF8,
            "application/json"
        );
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }
}

[JsonConverter(typeof(EventConverter))]
public enum Event
{
    OrderCreated,
    OrderPaid,
    OrderCancelled,
    StockLow,
    PaymentCreated,
    PaymentCompleted,
    PaymentFailed,
    CollectionPending,
    CollectionCompleted,
    CollectionFailed,
    WithdrawalCreated,
    WithdrawalCompleted,
    WithdrawalFailed,
    TransactionUpdated,
    TransferPending,
    TransferCompleted,
    TransferFailed,
    SettlementCompleted,
}

sealed class EventConverter : JsonConverter<Event>
{
    public override Event Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "order.created" => Event.OrderCreated,
            "order.paid" => Event.OrderPaid,
            "order.cancelled" => Event.OrderCancelled,
            "stock.low" => Event.StockLow,
            "payment.created" => Event.PaymentCreated,
            "payment.completed" => Event.PaymentCompleted,
            "payment.failed" => Event.PaymentFailed,
            "collection.pending" => Event.CollectionPending,
            "collection.completed" => Event.CollectionCompleted,
            "collection.failed" => Event.CollectionFailed,
            "withdrawal.created" => Event.WithdrawalCreated,
            "withdrawal.completed" => Event.WithdrawalCompleted,
            "withdrawal.failed" => Event.WithdrawalFailed,
            "transaction.updated" => Event.TransactionUpdated,
            "transfer.pending" => Event.TransferPending,
            "transfer.completed" => Event.TransferCompleted,
            "transfer.failed" => Event.TransferFailed,
            "settlement.completed" => Event.SettlementCompleted,
            _ => (Event)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Event value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Event.OrderCreated => "order.created",
                Event.OrderPaid => "order.paid",
                Event.OrderCancelled => "order.cancelled",
                Event.StockLow => "stock.low",
                Event.PaymentCreated => "payment.created",
                Event.PaymentCompleted => "payment.completed",
                Event.PaymentFailed => "payment.failed",
                Event.CollectionPending => "collection.pending",
                Event.CollectionCompleted => "collection.completed",
                Event.CollectionFailed => "collection.failed",
                Event.WithdrawalCreated => "withdrawal.created",
                Event.WithdrawalCompleted => "withdrawal.completed",
                Event.WithdrawalFailed => "withdrawal.failed",
                Event.TransactionUpdated => "transaction.updated",
                Event.TransferPending => "transfer.pending",
                Event.TransferCompleted => "transfer.completed",
                Event.TransferFailed => "transfer.failed",
                Event.SettlementCompleted => "settlement.completed",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
