using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Webhooks;

[JsonConverter(
    typeof(JsonModelConverter<WebhookDeactivateResponse, WebhookDeactivateResponseFromRaw>)
)]
public sealed record class WebhookDeactivateResponse : JsonModel
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

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
    }

    public WebhookDeactivateResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookDeactivateResponse(WebhookDeactivateResponse webhookDeactivateResponse)
        : base(webhookDeactivateResponse) { }
#pragma warning restore CS8618

    public WebhookDeactivateResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookDeactivateResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="WebhookDeactivateResponseFromRaw.FromRawUnchecked"/>
    public static WebhookDeactivateResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class WebhookDeactivateResponseFromRaw : IFromRawJson<WebhookDeactivateResponse>
{
    /// <inheritdoc/>
    public WebhookDeactivateResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => WebhookDeactivateResponse.FromRawUnchecked(rawData);
}
