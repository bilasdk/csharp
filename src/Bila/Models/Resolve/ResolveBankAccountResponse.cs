using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Resolve;

[JsonConverter(
    typeof(JsonModelConverter<ResolveBankAccountResponse, ResolveBankAccountResponseFromRaw>)
)]
public sealed record class ResolveBankAccountResponse : JsonModel
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

    public ResolveBankAccountResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolveBankAccountResponse(ResolveBankAccountResponse resolveBankAccountResponse)
        : base(resolveBankAccountResponse) { }
#pragma warning restore CS8618

    public ResolveBankAccountResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolveBankAccountResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolveBankAccountResponseFromRaw.FromRawUnchecked"/>
    public static ResolveBankAccountResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolveBankAccountResponseFromRaw : IFromRawJson<ResolveBankAccountResponse>
{
    /// <inheritdoc/>
    public ResolveBankAccountResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolveBankAccountResponse.FromRawUnchecked(rawData);
}
