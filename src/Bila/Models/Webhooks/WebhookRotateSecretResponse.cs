using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

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

    public WebhookRotateSecretResponseData? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WebhookRotateSecretResponseData>("data");
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
        WebhookRotateSecretResponseData,
        WebhookRotateSecretResponseDataFromRaw
    >)
)]
public sealed record class WebhookRotateSecretResponseData : JsonModel
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

    public WebhookRotateSecretResponseData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookRotateSecretResponseData(
        WebhookRotateSecretResponseData webhookRotateSecretResponseData
    )
        : base(webhookRotateSecretResponseData) { }
#pragma warning restore CS8618

    public WebhookRotateSecretResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookRotateSecretResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookRotateSecretResponseDataFromRaw.FromRawUnchecked"/>
    public static WebhookRotateSecretResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public WebhookRotateSecretResponseData(string secret)
        : this()
    {
        this.Secret = secret;
    }
}

class WebhookRotateSecretResponseDataFromRaw : IFromRawJson<WebhookRotateSecretResponseData>
{
    /// <inheritdoc/>
    public WebhookRotateSecretResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookRotateSecretResponseData.FromRawUnchecked(rawData);
}
