using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Resolve;

[JsonConverter(
    typeof(JsonModelConverter<ResolveMobileMoneyResponse, ResolveMobileMoneyResponseFromRaw>)
)]
public sealed record class ResolveMobileMoneyResponse : JsonModel
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

    public ResolvedAccountResponseDto? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ResolvedAccountResponseDto>("data");
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

    public ResolveMobileMoneyResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolveMobileMoneyResponse(ResolveMobileMoneyResponse resolveMobileMoneyResponse)
        : base(resolveMobileMoneyResponse) { }
#pragma warning restore CS8618

    public ResolveMobileMoneyResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolveMobileMoneyResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolveMobileMoneyResponseFromRaw.FromRawUnchecked"/>
    public static ResolveMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolveMobileMoneyResponseFromRaw : IFromRawJson<ResolveMobileMoneyResponse>
{
    /// <inheritdoc/>
    public ResolveMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolveMobileMoneyResponse.FromRawUnchecked(rawData);
}
