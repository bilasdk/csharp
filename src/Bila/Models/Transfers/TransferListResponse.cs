using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Accounts;
using System = System;

namespace Bila.Models.Transfers;

[JsonConverter(typeof(JsonModelConverter<TransferListResponse, TransferListResponseFromRaw>))]
public sealed record class TransferListResponse : JsonModel
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

    public TransferListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferListResponseIntersectionMember1Data>(
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

    public static implicit operator BilaResponse(TransferListResponse transferListResponse) =>
        new() { Message = transferListResponse.Message, Status = transferListResponse.Status };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransferListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferListResponse(TransferListResponse transferListResponse)
        : base(transferListResponse) { }
#pragma warning restore CS8618

    public TransferListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferListResponseFromRaw.FromRawUnchecked"/>
    public static TransferListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferListResponseFromRaw : IFromRawJson<TransferListResponse>
{
    /// <inheritdoc/>
    public TransferListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferListResponseIntersectionMember1,
        TransferListResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferListResponseIntersectionMember1 : JsonModel
{
    public TransferListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferListResponseIntersectionMember1Data>(
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

    public TransferListResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferListResponseIntersectionMember1(
        TransferListResponseIntersectionMember1 transferListResponseIntersectionMember1
    )
        : base(transferListResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferListResponseIntersectionMember1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferListResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferListResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferListResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferListResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferListResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferListResponseIntersectionMember1Data,
        TransferListResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferListResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// List of transfers
    /// </summary>
    public required IReadOnlyList<TransferListResponseIntersectionMember1DataData> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<TransferListResponseIntersectionMember1DataData>
            >("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<TransferListResponseIntersectionMember1DataData>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    public required global::Bila.Models.Transfers.Meta Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<global::Bila.Models.Transfers.Meta>("meta");
        }
        init { this._rawData.Set("meta", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.Data)
        {
            item.Validate();
        }
        this.Meta.Validate();
    }

    public TransferListResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferListResponseIntersectionMember1Data(
        TransferListResponseIntersectionMember1Data transferListResponseIntersectionMember1Data
    )
        : base(transferListResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferListResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferListResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferListResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferListResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferListResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferListResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferListResponseIntersectionMember1DataData,
        TransferListResponseIntersectionMember1DataDataFromRaw
    >)
)]
public sealed record class TransferListResponseIntersectionMember1DataData : JsonModel
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
    public required TransferListResponseIntersectionMember1DataDataRecipient Recipient
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<TransferListResponseIntersectionMember1DataDataRecipient>(
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
    public required ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferListResponseIntersectionMember1DataDataStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transfer type
    /// </summary>
    public required ApiEnum<string, TransferListResponseIntersectionMember1DataDataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferListResponseIntersectionMember1DataDataType>
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

    public TransferListResponseIntersectionMember1DataData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferListResponseIntersectionMember1DataData(
        TransferListResponseIntersectionMember1DataData transferListResponseIntersectionMember1DataData
    )
        : base(transferListResponseIntersectionMember1DataData) { }
#pragma warning restore CS8618

    public TransferListResponseIntersectionMember1DataData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferListResponseIntersectionMember1DataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferListResponseIntersectionMember1DataDataFromRaw.FromRawUnchecked"/>
    public static TransferListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferListResponseIntersectionMember1DataDataFromRaw
    : IFromRawJson<TransferListResponseIntersectionMember1DataData>
{
    /// <inheritdoc/>
    public TransferListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferListResponseIntersectionMember1DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Recipient details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        TransferListResponseIntersectionMember1DataDataRecipient,
        TransferListResponseIntersectionMember1DataDataRecipientFromRaw
    >)
)]
public sealed record class TransferListResponseIntersectionMember1DataDataRecipient : JsonModel
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

    public TransferListResponseIntersectionMember1DataDataRecipient() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferListResponseIntersectionMember1DataDataRecipient(
        TransferListResponseIntersectionMember1DataDataRecipient transferListResponseIntersectionMember1DataDataRecipient
    )
        : base(transferListResponseIntersectionMember1DataDataRecipient) { }
#pragma warning restore CS8618

    public TransferListResponseIntersectionMember1DataDataRecipient(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferListResponseIntersectionMember1DataDataRecipient(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferListResponseIntersectionMember1DataDataRecipientFromRaw.FromRawUnchecked"/>
    public static TransferListResponseIntersectionMember1DataDataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }

    [SetsRequiredMembers]
    public TransferListResponseIntersectionMember1DataDataRecipient(string accountName)
        : this()
    {
        this.AccountName = accountName;
    }
}

class TransferListResponseIntersectionMember1DataDataRecipientFromRaw
    : IFromRawJson<TransferListResponseIntersectionMember1DataDataRecipient>
{
    /// <inheritdoc/>
    public TransferListResponseIntersectionMember1DataDataRecipient FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferListResponseIntersectionMember1DataDataRecipient.FromRawUnchecked(rawData);
}

/// <summary>
/// Transfer status
/// </summary>
[JsonConverter(typeof(TransferListResponseIntersectionMember1DataDataStatusConverter))]
public enum TransferListResponseIntersectionMember1DataDataStatus
{
    Pending,
    Successful,
    Failed,
}

sealed class TransferListResponseIntersectionMember1DataDataStatusConverter
    : JsonConverter<TransferListResponseIntersectionMember1DataDataStatus>
{
    public override TransferListResponseIntersectionMember1DataDataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => TransferListResponseIntersectionMember1DataDataStatus.Pending,
            "successful" => TransferListResponseIntersectionMember1DataDataStatus.Successful,
            "failed" => TransferListResponseIntersectionMember1DataDataStatus.Failed,
            _ => (TransferListResponseIntersectionMember1DataDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferListResponseIntersectionMember1DataDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferListResponseIntersectionMember1DataDataStatus.Pending => "pending",
                TransferListResponseIntersectionMember1DataDataStatus.Successful => "successful",
                TransferListResponseIntersectionMember1DataDataStatus.Failed => "failed",
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
[JsonConverter(typeof(TransferListResponseIntersectionMember1DataDataTypeConverter))]
public enum TransferListResponseIntersectionMember1DataDataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferListResponseIntersectionMember1DataDataTypeConverter
    : JsonConverter<TransferListResponseIntersectionMember1DataDataType>
{
    public override TransferListResponseIntersectionMember1DataDataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" => TransferListResponseIntersectionMember1DataDataType.BankAccount,
            "mobile-money" => TransferListResponseIntersectionMember1DataDataType.MobileMoney,
            _ => (TransferListResponseIntersectionMember1DataDataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferListResponseIntersectionMember1DataDataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferListResponseIntersectionMember1DataDataType.BankAccount => "bank-account",
                TransferListResponseIntersectionMember1DataDataType.MobileMoney => "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Pagination metadata
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        global::Bila.Models.Transfers.Meta,
        global::Bila.Models.Transfers.MetaFromRaw
    >)
)]
public sealed record class Meta : JsonModel
{
    /// <summary>
    /// Current page number
    /// </summary>
    public required double CurrentPage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("currentPage");
        }
        init { this._rawData.Set("currentPage", value); }
    }

    /// <summary>
    /// Total number of pages
    /// </summary>
    public required double PageCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("pageCount");
        }
        init { this._rawData.Set("pageCount", value); }
    }

    /// <summary>
    /// Items per page
    /// </summary>
    public required double PerPage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("perPage");
        }
        init { this._rawData.Set("perPage", value); }
    }

    /// <summary>
    /// Total number of records
    /// </summary>
    public required double Total
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("total");
        }
        init { this._rawData.Set("total", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CurrentPage;
        _ = this.PageCount;
        _ = this.PerPage;
        _ = this.Total;
    }

    public Meta() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Meta(global::Bila.Models.Transfers.Meta meta)
        : base(meta) { }
#pragma warning restore CS8618

    public Meta(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Meta(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="global::Bila.Models.Transfers.MetaFromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.Transfers.Meta FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MetaFromRaw : IFromRawJson<global::Bila.Models.Transfers.Meta>
{
    /// <inheritdoc/>
    public global::Bila.Models.Transfers.Meta FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.Transfers.Meta.FromRawUnchecked(rawData);
}
