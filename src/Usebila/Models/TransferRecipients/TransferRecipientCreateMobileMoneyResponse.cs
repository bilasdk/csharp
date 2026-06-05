using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.TransferRecipients;

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientCreateMobileMoneyResponse,
        TransferRecipientCreateMobileMoneyResponseFromRaw
    >)
)]
public sealed record class TransferRecipientCreateMobileMoneyResponse : JsonModel
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

    public TransferRecipientCreateMobileMoneyResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateMobileMoneyResponse(
        TransferRecipientCreateMobileMoneyResponse transferRecipientCreateMobileMoneyResponse
    )
        : base(transferRecipientCreateMobileMoneyResponse) { }
#pragma warning restore CS8618

    public TransferRecipientCreateMobileMoneyResponse(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateMobileMoneyResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateMobileMoneyResponseFromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateMobileMoneyResponseFromRaw
    : IFromRawJson<TransferRecipientCreateMobileMoneyResponse>
{
    /// <inheritdoc/>
    public TransferRecipientCreateMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientCreateMobileMoneyResponse.FromRawUnchecked(rawData);
}
