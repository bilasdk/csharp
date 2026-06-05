using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Transfers;

[JsonConverter(
    typeof(JsonModelConverter<
        TransferGetStatusByReferenceResponse,
        TransferGetStatusByReferenceResponseFromRaw
    >)
)]
public sealed record class TransferGetStatusByReferenceResponse : JsonModel
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

    public TransferResponseDto? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferResponseDto>("data");
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

    public TransferGetStatusByReferenceResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferGetStatusByReferenceResponse(
        TransferGetStatusByReferenceResponse transferGetStatusByReferenceResponse
    )
        : base(transferGetStatusByReferenceResponse) { }
#pragma warning restore CS8618

    public TransferGetStatusByReferenceResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferGetStatusByReferenceResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferGetStatusByReferenceResponseFromRaw.FromRawUnchecked"/>
    public static TransferGetStatusByReferenceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferGetStatusByReferenceResponseFromRaw
    : IFromRawJson<TransferGetStatusByReferenceResponse>
{
    /// <inheritdoc/>
    public TransferGetStatusByReferenceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferGetStatusByReferenceResponse.FromRawUnchecked(rawData);
}
