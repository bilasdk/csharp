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

[JsonConverter(typeof(JsonModelConverter<WebhookUpdateResponse, WebhookUpdateResponseFromRaw>))]
public sealed record class WebhookUpdateResponse : JsonModel
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

    public WebhookUpdateResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WebhookUpdateResponseIntersectionMember1Data>(
                "data"
            );
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

    public static implicit operator BilaResponse(WebhookUpdateResponse webhookUpdateResponse) =>
        new() { Message = webhookUpdateResponse.Message, Status = webhookUpdateResponse.Status };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public WebhookUpdateResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookUpdateResponse(WebhookUpdateResponse webhookUpdateResponse)
        : base(webhookUpdateResponse) { }
#pragma warning restore CS8618

    public WebhookUpdateResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookUpdateResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookUpdateResponseFromRaw.FromRawUnchecked"/>
    public static WebhookUpdateResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookUpdateResponseFromRaw : IFromRawJson<WebhookUpdateResponse>
{
    /// <inheritdoc/>
    public WebhookUpdateResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookUpdateResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        WebhookUpdateResponseIntersectionMember1,
        WebhookUpdateResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class WebhookUpdateResponseIntersectionMember1 : JsonModel
{
    public WebhookUpdateResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WebhookUpdateResponseIntersectionMember1Data>(
                "data"
            );
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
        this.Data?.Validate();
    }

    public WebhookUpdateResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookUpdateResponseIntersectionMember1(
        WebhookUpdateResponseIntersectionMember1 webhookUpdateResponseIntersectionMember1
    )
        : base(webhookUpdateResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public WebhookUpdateResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookUpdateResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookUpdateResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static WebhookUpdateResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookUpdateResponseIntersectionMember1FromRaw
    : IFromRawJson<WebhookUpdateResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public WebhookUpdateResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookUpdateResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        WebhookUpdateResponseIntersectionMember1Data,
        WebhookUpdateResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class WebhookUpdateResponseIntersectionMember1Data : JsonModel
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

    public WebhookUpdateResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookUpdateResponseIntersectionMember1Data(
        WebhookUpdateResponseIntersectionMember1Data webhookUpdateResponseIntersectionMember1Data
    )
        : base(webhookUpdateResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public WebhookUpdateResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookUpdateResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookUpdateResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static WebhookUpdateResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookUpdateResponseIntersectionMember1DataFromRaw
    : IFromRawJson<WebhookUpdateResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public WebhookUpdateResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookUpdateResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}
