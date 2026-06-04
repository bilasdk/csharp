using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Accounts;
using System = System;

namespace Bila.Models.Transfers;

[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateMobileMoneyTransferResponse,
        TransferInitiateMobileMoneyTransferResponseFromRaw
    >)
)]
public sealed record class TransferInitiateMobileMoneyTransferResponse : JsonModel
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

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data>(
                "data"
            );
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

    public static implicit operator BilaResponse(
        TransferInitiateMobileMoneyTransferResponse transferInitiateMobileMoneyTransferResponse
    ) =>
        new()
        {
            Message = transferInitiateMobileMoneyTransferResponse.Message,
            Status = transferInitiateMobileMoneyTransferResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransferInitiateMobileMoneyTransferResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateMobileMoneyTransferResponse(
        TransferInitiateMobileMoneyTransferResponse transferInitiateMobileMoneyTransferResponse
    )
        : base(transferInitiateMobileMoneyTransferResponse) { }
#pragma warning restore CS8618

    public TransferInitiateMobileMoneyTransferResponse(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateMobileMoneyTransferResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateMobileMoneyTransferResponseFromRaw.FromRawUnchecked"/>
    public static TransferInitiateMobileMoneyTransferResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferInitiateMobileMoneyTransferResponseFromRaw
    : IFromRawJson<TransferInitiateMobileMoneyTransferResponse>
{
    /// <inheritdoc/>
    public TransferInitiateMobileMoneyTransferResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferInitiateMobileMoneyTransferResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferInitiateMobileMoneyTransferResponseIntersectionMember1
    : JsonModel
{
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data>(
                "data"
            );
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
        this.Data?.Validate();
    }

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1 transferInitiateMobileMoneyTransferResponseIntersectionMember1
    )
        : base(transferInitiateMobileMoneyTransferResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateMobileMoneyTransferResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateMobileMoneyTransferResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferInitiateMobileMoneyTransferResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferInitiateMobileMoneyTransferResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferInitiateMobileMoneyTransferResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferInitiateMobileMoneyTransferResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data
    : JsonModel
{
    /// <summary>
    /// Transfer ID
    /// </summary>
    public required string ID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("id");
        }
        init { this._rawData.Set("id", value); }
    }

    /// <summary>
    /// Transfer amount
    /// </summary>
    public required double Amount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("amount");
        }
        init { this._rawData.Set("amount", value); }
    }

    /// <summary>
    /// Creation timestamp (from Payment)
    /// </summary>
    public required System::DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<System::DateTimeOffset>("createdAt");
        }
        init { this._rawData.Set("createdAt", value); }
    }

    /// <summary>
    /// Currency code
    /// </summary>
    public required string Currency
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("currency");
        }
        init { this._rawData.Set("currency", value); }
    }

    /// <summary>
    /// Recipient details
    /// </summary>
    public required TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient Recipient
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient>(
                "recipient"
            );
        }
        init { this._rawData.Set("recipient", value); }
    }

    /// <summary>
    /// Client reference
    /// </summary>
    public required string Reference
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("reference");
        }
        init { this._rawData.Set("reference", value); }
    }

    /// <summary>
    /// Transfer status
    /// </summary>
    public required ApiEnum<
        string,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
    > Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<
                    string,
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
                >
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transfer type
    /// </summary>
    public required ApiEnum<
        string,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
    > Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<
                    string,
                    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
                >
            >("type");
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Completion timestamp (from Payment.processedAt)
    /// </summary>
    public System::DateTimeOffset? CompletedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<System::DateTimeOffset>("completedAt");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("completedAt", value);
        }
    }

    /// <summary>
    /// Transfer narration
    /// </summary>
    public string? Narration
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("narration");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("narration", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.Amount;
        _ = this.CreatedAt;
        _ = this.Currency;
        this.Recipient.Validate();
        _ = this.Reference;
        this.Status.Validate();
        this.Type.Validate();
        _ = this.CompletedAt;
        _ = this.Narration;
    }

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data transferInitiateMobileMoneyTransferResponseIntersectionMember1Data
    )
        : base(transferInitiateMobileMoneyTransferResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1Data.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Recipient details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipientFromRaw
    >)
)]
public sealed record class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
    : JsonModel
{
    /// <summary>
    /// Account holder / recipient name
    /// </summary>
    public required string AccountName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("accountName");
        }
        init { this._rawData.Set("accountName", value); }
    }

    /// <summary>
    /// Bank account number (bank-account only)
    /// </summary>
    public string? AccountNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("accountNumber");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("accountNumber", value);
        }
    }

    /// <summary>
    /// Bank name (bank-account only)
    /// </summary>
    public string? BankName
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("bankName");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("bankName", value);
        }
    }

    /// <summary>
    /// Mobile money operator (mobile-money only)
    /// </summary>
    public string? Operator
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("operator");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("operator", value);
        }
    }

    /// <summary>
    /// Phone number (mobile-money only)
    /// </summary>
    public string? Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("phone");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("phone", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AccountName;
        _ = this.AccountNumber;
        _ = this.BankName;
        _ = this.Operator;
        _ = this.Phone;
    }

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient(
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient transferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient
    )
        : base(transferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient) { }
#pragma warning restore CS8618

    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipientFromRaw.FromRawUnchecked"/>
    public static TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient(
        string accountName
    )
        : this()
    {
        this.AccountName = accountName;
    }
}

class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipientFromRaw
    : IFromRawJson<TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient>
{
    /// <inheritdoc/>
    public TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataRecipient.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Transfer status
/// </summary>
[JsonConverter(
    typeof(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatusConverter)
)]
public enum TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus
{
    Pending,
    Successful,
    Failed,
}

sealed class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatusConverter
    : JsonConverter<TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus>
{
    public override TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" =>
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Pending,
            "successful" =>
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful,
            "failed" =>
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Failed,
            _ => (TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Pending =>
                    "pending",
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Successful =>
                    "successful",
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataStatus.Failed =>
                    "failed",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Transfer type
/// </summary>
[JsonConverter(
    typeof(TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataTypeConverter)
)]
public enum TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataTypeConverter
    : JsonConverter<TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType>
{
    public override TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" =>
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount,
            "mobile-money" =>
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.MobileMoney,
            _ => (TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.BankAccount =>
                    "bank-account",
                TransferInitiateMobileMoneyTransferResponseIntersectionMember1DataType.MobileMoney =>
                    "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
