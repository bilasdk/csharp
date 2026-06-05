using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

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

    public WebhookConfigResponseDto? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<WebhookConfigResponseDto>("data");
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
