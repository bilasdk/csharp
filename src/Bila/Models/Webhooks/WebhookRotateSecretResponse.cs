using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Models.Webhooks;

[JsonConverter(
    typeof(JsonModelConverter<WebhookRotateSecretResponse, WebhookRotateSecretResponseFromRaw>)
)]
public sealed record class WebhookRotateSecretResponse : JsonModel
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

    public WebhookRotateSecretResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WebhookRotateSecretResponseIntersectionMember1Data>(
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

    public static implicit operator BilaResponse(
        WebhookRotateSecretResponse webhookRotateSecretResponse
    ) =>
        new()
        {
            Message = webhookRotateSecretResponse.Message,
            Status = webhookRotateSecretResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public WebhookRotateSecretResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookRotateSecretResponse(WebhookRotateSecretResponse webhookRotateSecretResponse)
        : base(webhookRotateSecretResponse) { }
#pragma warning restore CS8618

    public WebhookRotateSecretResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookRotateSecretResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookRotateSecretResponseFromRaw.FromRawUnchecked"/>
    public static WebhookRotateSecretResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookRotateSecretResponseFromRaw : IFromRawJson<WebhookRotateSecretResponse>
{
    /// <inheritdoc/>
    public WebhookRotateSecretResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookRotateSecretResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        WebhookRotateSecretResponseIntersectionMember1,
        WebhookRotateSecretResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class WebhookRotateSecretResponseIntersectionMember1 : JsonModel
{
    public WebhookRotateSecretResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WebhookRotateSecretResponseIntersectionMember1Data>(
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

    public WebhookRotateSecretResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookRotateSecretResponseIntersectionMember1(
        WebhookRotateSecretResponseIntersectionMember1 webhookRotateSecretResponseIntersectionMember1
    )
        : base(webhookRotateSecretResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public WebhookRotateSecretResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookRotateSecretResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookRotateSecretResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static WebhookRotateSecretResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookRotateSecretResponseIntersectionMember1FromRaw
    : IFromRawJson<WebhookRotateSecretResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public WebhookRotateSecretResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookRotateSecretResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        WebhookRotateSecretResponseIntersectionMember1Data,
        WebhookRotateSecretResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class WebhookRotateSecretResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// New signing secret (64-character hex, shown once)
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Secret;
    }

    public WebhookRotateSecretResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookRotateSecretResponseIntersectionMember1Data(
        WebhookRotateSecretResponseIntersectionMember1Data webhookRotateSecretResponseIntersectionMember1Data
    )
        : base(webhookRotateSecretResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public WebhookRotateSecretResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookRotateSecretResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookRotateSecretResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static WebhookRotateSecretResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public WebhookRotateSecretResponseIntersectionMember1Data(string secret)
        : this()
    {
        this.Secret = secret;
    }
}

class WebhookRotateSecretResponseIntersectionMember1DataFromRaw
    : IFromRawJson<WebhookRotateSecretResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public WebhookRotateSecretResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookRotateSecretResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}
