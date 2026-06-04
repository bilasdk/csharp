using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Models.Webhooks;

[JsonConverter(typeof(JsonModelConverter<WebhookListResponse, WebhookListResponseFromRaw>))]
public sealed record class WebhookListResponse : JsonModel
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

    public IReadOnlyList<WebhookListResponseIntersectionMember1Data>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<WebhookListResponseIntersectionMember1Data>
            >("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<WebhookListResponseIntersectionMember1Data>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    public static implicit operator BilaResponse(WebhookListResponse webhookListResponse) =>
        new() { Message = webhookListResponse.Message, Status = webhookListResponse.Status };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        foreach (var item in this.Data ?? [])
        {
            item.Validate();
        }
    }

    public WebhookListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookListResponse(WebhookListResponse webhookListResponse)
        : base(webhookListResponse) { }
#pragma warning restore CS8618

    public WebhookListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookListResponseFromRaw.FromRawUnchecked"/>
    public static WebhookListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookListResponseFromRaw : IFromRawJson<WebhookListResponse>
{
    /// <inheritdoc/>
    public WebhookListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        WebhookListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        WebhookListResponseIntersectionMember1,
        WebhookListResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class WebhookListResponseIntersectionMember1 : JsonModel
{
    public IReadOnlyList<WebhookListResponseIntersectionMember1Data>? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<
                ImmutableArray<WebhookListResponseIntersectionMember1Data>
            >("data");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set<ImmutableArray<WebhookListResponseIntersectionMember1Data>?>(
                "data",
                value == null ? null : ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Data ?? [])
        {
            item.Validate();
        }
    }

    public WebhookListResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookListResponseIntersectionMember1(
        WebhookListResponseIntersectionMember1 webhookListResponseIntersectionMember1
    )
        : base(webhookListResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public WebhookListResponseIntersectionMember1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookListResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookListResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static WebhookListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookListResponseIntersectionMember1FromRaw
    : IFromRawJson<WebhookListResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public WebhookListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookListResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        WebhookListResponseIntersectionMember1Data,
        WebhookListResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class WebhookListResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// Webhook config UUID
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
    /// Subscribed event types
    /// </summary>
    public required IReadOnlyList<string> Events
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<string>>("events");
        }
        init
        {
            this._rawData.Set<ImmutableArray<string>>(
                "events",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Whether the webhook is active
    /// </summary>
    public required bool IsActive
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<bool>("isActive");
        }
        init { this._rawData.Set("isActive", value); }
    }

    /// <summary>
    /// Merchant UUID
    /// </summary>
    public required string MerchantID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("merchantId");
        }
        init { this._rawData.Set("merchantId", value); }
    }

    /// <summary>
    /// Signing secret; plaintext only on create/rotate-secret, otherwise masked
    /// </summary>
    public required string Secret
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("secret");
        }
        init { this._rawData.Set("secret", value); }
    }

    public required DateTimeOffset UpdatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("updatedAt");
        }
        init { this._rawData.Set("updatedAt", value); }
    }

    /// <summary>
    /// Webhook endpoint URL
    /// </summary>
    public required string Url
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("url");
        }
        init { this._rawData.Set("url", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.CreatedAt;
        _ = this.Events;
        _ = this.IsActive;
        _ = this.MerchantID;
        _ = this.Secret;
        _ = this.UpdatedAt;
        _ = this.Url;
    }

    public WebhookListResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookListResponseIntersectionMember1Data(
        WebhookListResponseIntersectionMember1Data webhookListResponseIntersectionMember1Data
    )
        : base(webhookListResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public WebhookListResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookListResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookListResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static WebhookListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookListResponseIntersectionMember1DataFromRaw
    : IFromRawJson<WebhookListResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public WebhookListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookListResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}
