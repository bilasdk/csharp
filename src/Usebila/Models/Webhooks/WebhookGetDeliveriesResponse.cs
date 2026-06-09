using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;
using Usebila.Exceptions;

namespace Usebila.Models.Webhooks;

[JsonConverter(
    typeof(JsonModelConverter<WebhookGetDeliveriesResponse, WebhookGetDeliveriesResponseFromRaw>)
)]
public sealed record class WebhookGetDeliveriesResponse : JsonModel
{
    /// <summary>
    /// Response message
    /// </summary>
    public required string Message
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("message");
        }
        init { this._rawData.Set("message", value); }
    }

    /// <summary>
    /// Request success status
    /// </summary>
    public required bool Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    public Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Data>("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("data", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public WebhookGetDeliveriesResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookGetDeliveriesResponse(WebhookGetDeliveriesResponse webhookGetDeliveriesResponse)
        : base(webhookGetDeliveriesResponse) { }
#pragma warning restore CS8618

    public WebhookGetDeliveriesResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookGetDeliveriesResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookGetDeliveriesResponseFromRaw.FromRawUnchecked"/>
    public static WebhookGetDeliveriesResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookGetDeliveriesResponseFromRaw : IFromRawJson<WebhookGetDeliveriesResponse>
{
    /// <inheritdoc/>
    public WebhookGetDeliveriesResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookGetDeliveriesResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// List of webhook deliveries
    /// </summary>
    public required IReadOnlyList<DataData> DataValue
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<DataData>>("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<DataData>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    public required PaginationMetaDto Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaginationMetaDto>("meta");
        }
        init { this._rawData.Set("meta", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.DataValue)
        {
            item.Validate();
        }
        this.Meta.Validate();
    }

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(Data data)
        : base(data) { }
#pragma warning restore CS8618

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<DataData, DataDataFromRaw>))]
public sealed record class DataData : JsonModel
{
    /// <summary>
    /// Delivery UUID
    /// </summary>
    public required string ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("id");
        }
        init { this._rawData.Set("id", value); }
    }

    /// <summary>
    /// Number of delivery attempts
    /// </summary>
    public required double Attempts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("attempts");
        }
        init { this._rawData.Set("attempts", value); }
    }

    public required DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("createdAt");
        }
        init { this._rawData.Set("createdAt", value); }
    }

    /// <summary>
    /// When the delivery succeeded
    /// </summary>
    public required DateTimeOffset? DeliveredAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("deliveredAt");
        }
        init { this._rawData.Set("deliveredAt", value); }
    }

    /// <summary>
    /// Webhook event type
    /// </summary>
    public required string EventType
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("eventType");
        }
        init { this._rawData.Set("eventType", value); }
    }

    /// <summary>
    /// When the delivery permanently failed
    /// </summary>
    public required DateTimeOffset? FailedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("failedAt");
        }
        init { this._rawData.Set("failedAt", value); }
    }

    /// <summary>
    /// Maximum delivery attempts
    /// </summary>
    public required double MaxAttempts
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("maxAttempts");
        }
        init { this._rawData.Set("maxAttempts", value); }
    }

    /// <summary>
    /// When the next retry is scheduled
    /// </summary>
    public required DateTimeOffset? NextRetryAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("nextRetryAt");
        }
        init { this._rawData.Set("nextRetryAt", value); }
    }

    /// <summary>
    /// Event payload JSON as stored for delivery
    /// </summary>
    public required IReadOnlyDictionary<string, JsonElement> Payload
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<FrozenDictionary<string, JsonElement>>("payload");
        }
        init
        {
            this._rawData.Set<FrozenDictionary<string, JsonElement>>(
                "payload",
                FrozenDictionary.ToFrozenDictionary(value)
            );
        }
    }

    /// <summary>
    /// Response body from the merchant endpoint (truncated)
    /// </summary>
    public required string? ResponseBody
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("responseBody");
        }
        init { this._rawData.Set("responseBody", value); }
    }

    /// <summary>
    /// HTTP status code from the merchant endpoint
    /// </summary>
    public required double? ResponseStatus
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<double>("responseStatus");
        }
        init { this._rawData.Set("responseStatus", value); }
    }

    /// <summary>
    /// Delivery status
    /// </summary>
    public required ApiEnum<string, Status> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Status>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Webhook config UUID
    /// </summary>
    public required string WebhookConfigID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("webhookConfigId");
        }
        init { this._rawData.Set("webhookConfigId", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Attempts;
        _ = this.CreatedAt;
        _ = this.DeliveredAt;
        _ = this.EventType;
        _ = this.FailedAt;
        _ = this.MaxAttempts;
        _ = this.NextRetryAt;
        _ = this.Payload;
        _ = this.ResponseBody;
        _ = this.ResponseStatus;
        this.Status.Validate();
        _ = this.WebhookConfigID;
    }

    public DataData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public DataData(DataData dataData)
        : base(dataData) { }
#pragma warning restore CS8618

    public DataData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    DataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="DataDataFromRaw.FromRawUnchecked"/>
    public static DataData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataDataFromRaw : IFromRawJson<DataData>
{
    /// <inheritdoc/>
    public DataData FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Delivery status
/// </summary>
[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Queued,
    Delivered,
    Failed,
    Retrying,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "QUEUED" => Status.Queued,
            "DELIVERED" => Status.Delivered,
            "FAILED" => Status.Failed,
            "RETRYING" => Status.Retrying,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Queued => "QUEUED",
                Status.Delivered => "DELIVERED",
                Status.Failed => "FAILED",
                Status.Retrying => "RETRYING",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
