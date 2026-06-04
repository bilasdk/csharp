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

    public TransferGetStatusByReferenceResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferGetStatusByReferenceResponseIntersectionMember1Data>(
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
        TransferGetStatusByReferenceResponse transferGetStatusByReferenceResponse
    ) =>
        new()
        {
            Message = transferGetStatusByReferenceResponse.Message,
            Status = transferGetStatusByReferenceResponse.Status,
        };

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

[JsonConverter(
    typeof(JsonModelConverter<
        TransferGetStatusByReferenceResponseIntersectionMember1,
        TransferGetStatusByReferenceResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferGetStatusByReferenceResponseIntersectionMember1 : JsonModel
{
    public TransferGetStatusByReferenceResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferGetStatusByReferenceResponseIntersectionMember1Data>(
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

    public TransferGetStatusByReferenceResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferGetStatusByReferenceResponseIntersectionMember1(
        TransferGetStatusByReferenceResponseIntersectionMember1 transferGetStatusByReferenceResponseIntersectionMember1
    )
        : base(transferGetStatusByReferenceResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferGetStatusByReferenceResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferGetStatusByReferenceResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferGetStatusByReferenceResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferGetStatusByReferenceResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferGetStatusByReferenceResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferGetStatusByReferenceResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferGetStatusByReferenceResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferGetStatusByReferenceResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferGetStatusByReferenceResponseIntersectionMember1Data,
        TransferGetStatusByReferenceResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferGetStatusByReferenceResponseIntersectionMember1Data : JsonModel
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
    public required TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient Recipient
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient>(
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
        TransferGetStatusByReferenceResponseIntersectionMember1DataStatus
    > Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferGetStatusByReferenceResponseIntersectionMember1DataStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transfer type
    /// </summary>
    public required ApiEnum<
        string,
        TransferGetStatusByReferenceResponseIntersectionMember1DataType
    > Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferGetStatusByReferenceResponseIntersectionMember1DataType>
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

    public TransferGetStatusByReferenceResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferGetStatusByReferenceResponseIntersectionMember1Data(
        TransferGetStatusByReferenceResponseIntersectionMember1Data transferGetStatusByReferenceResponseIntersectionMember1Data
    )
        : base(transferGetStatusByReferenceResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferGetStatusByReferenceResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferGetStatusByReferenceResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferGetStatusByReferenceResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferGetStatusByReferenceResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferGetStatusByReferenceResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferGetStatusByReferenceResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferGetStatusByReferenceResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferGetStatusByReferenceResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Recipient details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient,
        TransferGetStatusByReferenceResponseIntersectionMember1DataRecipientFromRaw
    >)
)]
public sealed record class TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient
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

    public TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient(
        TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient transferGetStatusByReferenceResponseIntersectionMember1DataRecipient
    )
        : base(transferGetStatusByReferenceResponseIntersectionMember1DataRecipient) { }
#pragma warning restore CS8618

    public TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferGetStatusByReferenceResponseIntersectionMember1DataRecipientFromRaw.FromRawUnchecked"/>
    public static TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient(string accountName)
        : this()
    {
        this.AccountName = accountName;
    }
}

class TransferGetStatusByReferenceResponseIntersectionMember1DataRecipientFromRaw
    : IFromRawJson<TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient>
{
    /// <inheritdoc/>
    public TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        TransferGetStatusByReferenceResponseIntersectionMember1DataRecipient.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Transfer status
/// </summary>
[JsonConverter(typeof(TransferGetStatusByReferenceResponseIntersectionMember1DataStatusConverter))]
public enum TransferGetStatusByReferenceResponseIntersectionMember1DataStatus
{
    Pending,
    Successful,
    Failed,
}

sealed class TransferGetStatusByReferenceResponseIntersectionMember1DataStatusConverter
    : JsonConverter<TransferGetStatusByReferenceResponseIntersectionMember1DataStatus>
{
    public override TransferGetStatusByReferenceResponseIntersectionMember1DataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => TransferGetStatusByReferenceResponseIntersectionMember1DataStatus.Pending,
            "successful" =>
                TransferGetStatusByReferenceResponseIntersectionMember1DataStatus.Successful,
            "failed" => TransferGetStatusByReferenceResponseIntersectionMember1DataStatus.Failed,
            _ => (TransferGetStatusByReferenceResponseIntersectionMember1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferGetStatusByReferenceResponseIntersectionMember1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferGetStatusByReferenceResponseIntersectionMember1DataStatus.Pending =>
                    "pending",
                TransferGetStatusByReferenceResponseIntersectionMember1DataStatus.Successful =>
                    "successful",
                TransferGetStatusByReferenceResponseIntersectionMember1DataStatus.Failed =>
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
[JsonConverter(typeof(TransferGetStatusByReferenceResponseIntersectionMember1DataTypeConverter))]
public enum TransferGetStatusByReferenceResponseIntersectionMember1DataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferGetStatusByReferenceResponseIntersectionMember1DataTypeConverter
    : JsonConverter<TransferGetStatusByReferenceResponseIntersectionMember1DataType>
{
    public override TransferGetStatusByReferenceResponseIntersectionMember1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" =>
                TransferGetStatusByReferenceResponseIntersectionMember1DataType.BankAccount,
            "mobile-money" =>
                TransferGetStatusByReferenceResponseIntersectionMember1DataType.MobileMoney,
            _ => (TransferGetStatusByReferenceResponseIntersectionMember1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferGetStatusByReferenceResponseIntersectionMember1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferGetStatusByReferenceResponseIntersectionMember1DataType.BankAccount =>
                    "bank-account",
                TransferGetStatusByReferenceResponseIntersectionMember1DataType.MobileMoney =>
                    "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
