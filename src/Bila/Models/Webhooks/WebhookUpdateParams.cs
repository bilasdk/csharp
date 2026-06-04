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
/// Update a webhook config
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class WebhookUpdateParams : ParamsBase
{
    readonly JsonDictionary _rawBodyData = new();
    public IReadOnlyDictionary<string, JsonElement> RawBodyData
    {
        get { return this._rawBodyData.Freeze(); }
    }

    public string? ID { get; init; }

    /// <summary>
    /// Event types to subscribe to
    /// </summary>
    public IReadOnlyList<ApiEnum<string, WebhookUpdateParamsEvent>>? Events
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<
                ImmutableArray<ApiEnum<string, WebhookUpdateParamsEvent>>
            >("events");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set<ImmutableArray<ApiEnum<string, WebhookUpdateParamsEvent>>?>(
                "events",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Whether the webhook is active
    /// </summary>
    public bool? IsActive
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableStruct<bool>("isActive");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("isActive", value);
        }
    }

    /// <summary>
    /// Webhook endpoint URL
    /// </summary>
    public string? UrlValue
    {
        get
        {
            this._rawBodyData.Freeze();
            return this._rawBodyData.GetNullableClass<string>("url");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawBodyData.Set("url", value);
        }
    }

    public WebhookUpdateParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookUpdateParams(WebhookUpdateParams webhookUpdateParams)
        : base(webhookUpdateParams)
    {
        this.ID = webhookUpdateParams.ID;

        this._rawBodyData = new(webhookUpdateParams._rawBodyData);
    }
#pragma warning restore CS8618

    public WebhookUpdateParams(
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
    WebhookUpdateParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        FrozenDictionary<string, JsonElement> rawBodyData,
        string id
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this._rawBodyData = new(rawBodyData);
        this.ID = id;
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson{T}.FromRawUnchecked"/>
    public static WebhookUpdateParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        IReadOnlyDictionary<string, JsonElement> rawBodyData,
        string id
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            FrozenDictionary.ToFrozenDictionary(rawBodyData),
            id
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(
                new Dictionary<string, JsonElement>()
                {
                    ["ID"] = JsonSerializer.SerializeToElement(this.ID),
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

    public virtual bool Equals(WebhookUpdateParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return (this.ID?.Equals(other.ID) ?? other.ID == null)
            && this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData)
            && this._rawBodyData.Equals(other._rawBodyData);
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/api/v1/bila/webhooks/{0}", this.ID)
        )
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

[JsonConverter(typeof(WebhookUpdateParamsEventConverter))]
public enum WebhookUpdateParamsEvent
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

sealed class WebhookUpdateParamsEventConverter : JsonConverter<WebhookUpdateParamsEvent>
{
    public override WebhookUpdateParamsEvent Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "order.created" => WebhookUpdateParamsEvent.OrderCreated,
            "order.paid" => WebhookUpdateParamsEvent.OrderPaid,
            "order.cancelled" => WebhookUpdateParamsEvent.OrderCancelled,
            "stock.low" => WebhookUpdateParamsEvent.StockLow,
            "payment.created" => WebhookUpdateParamsEvent.PaymentCreated,
            "payment.completed" => WebhookUpdateParamsEvent.PaymentCompleted,
            "payment.failed" => WebhookUpdateParamsEvent.PaymentFailed,
            "collection.pending" => WebhookUpdateParamsEvent.CollectionPending,
            "collection.completed" => WebhookUpdateParamsEvent.CollectionCompleted,
            "collection.failed" => WebhookUpdateParamsEvent.CollectionFailed,
            "withdrawal.created" => WebhookUpdateParamsEvent.WithdrawalCreated,
            "withdrawal.completed" => WebhookUpdateParamsEvent.WithdrawalCompleted,
            "withdrawal.failed" => WebhookUpdateParamsEvent.WithdrawalFailed,
            "transaction.updated" => WebhookUpdateParamsEvent.TransactionUpdated,
            "transfer.pending" => WebhookUpdateParamsEvent.TransferPending,
            "transfer.completed" => WebhookUpdateParamsEvent.TransferCompleted,
            "transfer.failed" => WebhookUpdateParamsEvent.TransferFailed,
            "settlement.completed" => WebhookUpdateParamsEvent.SettlementCompleted,
            _ => (WebhookUpdateParamsEvent)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        WebhookUpdateParamsEvent value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                WebhookUpdateParamsEvent.OrderCreated => "order.created",
                WebhookUpdateParamsEvent.OrderPaid => "order.paid",
                WebhookUpdateParamsEvent.OrderCancelled => "order.cancelled",
                WebhookUpdateParamsEvent.StockLow => "stock.low",
                WebhookUpdateParamsEvent.PaymentCreated => "payment.created",
                WebhookUpdateParamsEvent.PaymentCompleted => "payment.completed",
                WebhookUpdateParamsEvent.PaymentFailed => "payment.failed",
                WebhookUpdateParamsEvent.CollectionPending => "collection.pending",
                WebhookUpdateParamsEvent.CollectionCompleted => "collection.completed",
                WebhookUpdateParamsEvent.CollectionFailed => "collection.failed",
                WebhookUpdateParamsEvent.WithdrawalCreated => "withdrawal.created",
                WebhookUpdateParamsEvent.WithdrawalCompleted => "withdrawal.completed",
                WebhookUpdateParamsEvent.WithdrawalFailed => "withdrawal.failed",
                WebhookUpdateParamsEvent.TransactionUpdated => "transaction.updated",
                WebhookUpdateParamsEvent.TransferPending => "transfer.pending",
                WebhookUpdateParamsEvent.TransferCompleted => "transfer.completed",
                WebhookUpdateParamsEvent.TransferFailed => "transfer.failed",
                WebhookUpdateParamsEvent.SettlementCompleted => "settlement.completed",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
