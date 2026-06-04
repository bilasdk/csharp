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
        TransferInitiateBankTransferResponse,
        TransferInitiateBankTransferResponseFromRaw
    >)
)]
public sealed record class TransferInitiateBankTransferResponse : JsonModel
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

    public TransferInitiateBankTransferResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferInitiateBankTransferResponseIntersectionMember1Data>(
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
        TransferInitiateBankTransferResponse transferInitiateBankTransferResponse
    ) =>
        new()
        {
            Message = transferInitiateBankTransferResponse.Message,
            Status = transferInitiateBankTransferResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransferInitiateBankTransferResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateBankTransferResponse(
        TransferInitiateBankTransferResponse transferInitiateBankTransferResponse
    )
        : base(transferInitiateBankTransferResponse) { }
#pragma warning restore CS8618

    public TransferInitiateBankTransferResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateBankTransferResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateBankTransferResponseFromRaw.FromRawUnchecked"/>
    public static TransferInitiateBankTransferResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferInitiateBankTransferResponseFromRaw
    : IFromRawJson<TransferInitiateBankTransferResponse>
{
    /// <inheritdoc/>
    public TransferInitiateBankTransferResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferInitiateBankTransferResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateBankTransferResponseIntersectionMember1,
        TransferInitiateBankTransferResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferInitiateBankTransferResponseIntersectionMember1 : JsonModel
{
    public TransferInitiateBankTransferResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferInitiateBankTransferResponseIntersectionMember1Data>(
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

    public TransferInitiateBankTransferResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateBankTransferResponseIntersectionMember1(
        TransferInitiateBankTransferResponseIntersectionMember1 transferInitiateBankTransferResponseIntersectionMember1
    )
        : base(transferInitiateBankTransferResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferInitiateBankTransferResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateBankTransferResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateBankTransferResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferInitiateBankTransferResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferInitiateBankTransferResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferInitiateBankTransferResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferInitiateBankTransferResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferInitiateBankTransferResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateBankTransferResponseIntersectionMember1Data,
        TransferInitiateBankTransferResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferInitiateBankTransferResponseIntersectionMember1Data : JsonModel
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
    public required TransferInitiateBankTransferResponseIntersectionMember1DataRecipient Recipient
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<TransferInitiateBankTransferResponseIntersectionMember1DataRecipient>(
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
        TransferInitiateBankTransferResponseIntersectionMember1DataStatus
    > Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferInitiateBankTransferResponseIntersectionMember1DataStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transfer type
    /// </summary>
    public required ApiEnum<
        string,
        TransferInitiateBankTransferResponseIntersectionMember1DataType
    > Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferInitiateBankTransferResponseIntersectionMember1DataType>
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

    public TransferInitiateBankTransferResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateBankTransferResponseIntersectionMember1Data(
        TransferInitiateBankTransferResponseIntersectionMember1Data transferInitiateBankTransferResponseIntersectionMember1Data
    )
        : base(transferInitiateBankTransferResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferInitiateBankTransferResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateBankTransferResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateBankTransferResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferInitiateBankTransferResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferInitiateBankTransferResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferInitiateBankTransferResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferInitiateBankTransferResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferInitiateBankTransferResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Recipient details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        TransferInitiateBankTransferResponseIntersectionMember1DataRecipient,
        TransferInitiateBankTransferResponseIntersectionMember1DataRecipientFromRaw
    >)
)]
public sealed record class TransferInitiateBankTransferResponseIntersectionMember1DataRecipient
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

    public TransferInitiateBankTransferResponseIntersectionMember1DataRecipient() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferInitiateBankTransferResponseIntersectionMember1DataRecipient(
        TransferInitiateBankTransferResponseIntersectionMember1DataRecipient transferInitiateBankTransferResponseIntersectionMember1DataRecipient
    )
        : base(transferInitiateBankTransferResponseIntersectionMember1DataRecipient) { }
#pragma warning restore CS8618

    public TransferInitiateBankTransferResponseIntersectionMember1DataRecipient(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferInitiateBankTransferResponseIntersectionMember1DataRecipient(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferInitiateBankTransferResponseIntersectionMember1DataRecipientFromRaw.FromRawUnchecked"/>
    public static TransferInitiateBankTransferResponseIntersectionMember1DataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public TransferInitiateBankTransferResponseIntersectionMember1DataRecipient(string accountName)
        : this()
    {
        this.AccountName = accountName;
    }
}

class TransferInitiateBankTransferResponseIntersectionMember1DataRecipientFromRaw
    : IFromRawJson<TransferInitiateBankTransferResponseIntersectionMember1DataRecipient>
{
    /// <inheritdoc/>
    public TransferInitiateBankTransferResponseIntersectionMember1DataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        TransferInitiateBankTransferResponseIntersectionMember1DataRecipient.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Transfer status
/// </summary>
[JsonConverter(typeof(TransferInitiateBankTransferResponseIntersectionMember1DataStatusConverter))]
public enum TransferInitiateBankTransferResponseIntersectionMember1DataStatus
{
    Pending,
    Successful,
    Failed,
}

sealed class TransferInitiateBankTransferResponseIntersectionMember1DataStatusConverter
    : JsonConverter<TransferInitiateBankTransferResponseIntersectionMember1DataStatus>
{
    public override TransferInitiateBankTransferResponseIntersectionMember1DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => TransferInitiateBankTransferResponseIntersectionMember1DataStatus.Pending,
            "successful" =>
                TransferInitiateBankTransferResponseIntersectionMember1DataStatus.Successful,
            "failed" => TransferInitiateBankTransferResponseIntersectionMember1DataStatus.Failed,
            _ => (TransferInitiateBankTransferResponseIntersectionMember1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferInitiateBankTransferResponseIntersectionMember1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferInitiateBankTransferResponseIntersectionMember1DataStatus.Pending =>
                    "pending",
                TransferInitiateBankTransferResponseIntersectionMember1DataStatus.Successful =>
                    "successful",
                TransferInitiateBankTransferResponseIntersectionMember1DataStatus.Failed =>
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
[JsonConverter(typeof(TransferInitiateBankTransferResponseIntersectionMember1DataTypeConverter))]
public enum TransferInitiateBankTransferResponseIntersectionMember1DataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferInitiateBankTransferResponseIntersectionMember1DataTypeConverter
    : JsonConverter<TransferInitiateBankTransferResponseIntersectionMember1DataType>
{
    public override TransferInitiateBankTransferResponseIntersectionMember1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" =>
                TransferInitiateBankTransferResponseIntersectionMember1DataType.BankAccount,
            "mobile-money" =>
                TransferInitiateBankTransferResponseIntersectionMember1DataType.MobileMoney,
            _ => (TransferInitiateBankTransferResponseIntersectionMember1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferInitiateBankTransferResponseIntersectionMember1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferInitiateBankTransferResponseIntersectionMember1DataType.BankAccount =>
                    "bank-account",
                TransferInitiateBankTransferResponseIntersectionMember1DataType.MobileMoney =>
                    "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
