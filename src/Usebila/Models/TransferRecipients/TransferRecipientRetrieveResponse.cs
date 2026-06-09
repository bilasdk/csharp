using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.TransferRecipients;

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientRetrieveResponse,
        TransferRecipientRetrieveResponseFromRaw
    >)
)]
public sealed record class TransferRecipientRetrieveResponse : JsonModel
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

    public RecipientResponseDto? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<RecipientResponseDto>("data");
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

    public TransferRecipientRetrieveResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientRetrieveResponse(
        TransferRecipientRetrieveResponse transferRecipientRetrieveResponse
    )
        : base(transferRecipientRetrieveResponse) { }
#pragma warning restore CS8618

    public TransferRecipientRetrieveResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientRetrieveResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientRetrieveResponseFromRaw.FromRawUnchecked"/>
    public static TransferRecipientRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientRetrieveResponseFromRaw : IFromRawJson<TransferRecipientRetrieveResponse>
{
    /// <inheritdoc/>
    public TransferRecipientRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientRetrieveResponse.FromRawUnchecked(rawData);
}
