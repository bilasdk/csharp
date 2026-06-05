using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Webhooks;

[JsonConverter(
    typeof(JsonModelConverter<WebhookConfigResponseDto, WebhookConfigResponseDtoFromRaw>)
)]
public sealed record class WebhookConfigResponseDto : JsonModel
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

    public WebhookConfigResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookConfigResponseDto(WebhookConfigResponseDto webhookConfigResponseDto)
        : base(webhookConfigResponseDto) { }
#pragma warning restore CS8618

    public WebhookConfigResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookConfigResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookConfigResponseDtoFromRaw.FromRawUnchecked"/>
    public static WebhookConfigResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookConfigResponseDtoFromRaw : IFromRawJson<WebhookConfigResponseDto>
{
    /// <inheritdoc/>
    public WebhookConfigResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookConfigResponseDto.FromRawUnchecked(rawData);
}
