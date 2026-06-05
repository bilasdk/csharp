using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Transfers;

[JsonConverter(
    typeof(JsonModelConverter<TransferRetrieveResponse, TransferRetrieveResponseFromRaw>)
)]
public sealed record class TransferRetrieveResponse : JsonModel
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

    public TransferRetrieveResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRetrieveResponse(TransferRetrieveResponse transferRetrieveResponse)
        : base(transferRetrieveResponse) { }
#pragma warning restore CS8618

    public TransferRetrieveResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRetrieveResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRetrieveResponseFromRaw.FromRawUnchecked"/>
    public static TransferRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRetrieveResponseFromRaw : IFromRawJson<TransferRetrieveResponse>
{
    /// <inheritdoc/>
    public TransferRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRetrieveResponse.FromRawUnchecked(rawData);
}
