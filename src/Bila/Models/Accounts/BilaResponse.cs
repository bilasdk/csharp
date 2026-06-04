using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Accounts;

[JsonConverter(typeof(JsonModelConverter<BilaResponse, BilaResponseFromRaw>))]
public sealed record class BilaResponse : JsonModel
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

    public BilaResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public BilaResponse(BilaResponse bilaResponse)
        : base(bilaResponse) { }
#pragma warning restore CS8618

    public BilaResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BilaResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BilaResponseFromRaw.FromRawUnchecked"/>
    public static BilaResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BilaResponseFromRaw : IFromRawJson<BilaResponse>
{
    /// <inheritdoc/>
    public BilaResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        BilaResponse.FromRawUnchecked(rawData);
}
