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

namespace Bila.Models.Transactions;

[JsonConverter(typeof(JsonModelConverter<TransactionListResponse, TransactionListResponseFromRaw>))]
public sealed record class TransactionListResponse : JsonModel
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

    public TransactionListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransactionListResponseIntersectionMember1Data>(
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

    public static implicit operator BilaResponse(TransactionListResponse transactionListResponse) =>
        new()
        {
            Message = transactionListResponse.Message,
            Status = transactionListResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransactionListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionListResponse(TransactionListResponse transactionListResponse)
        : base(transactionListResponse) { }
#pragma warning restore CS8618

    public TransactionListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionListResponseFromRaw.FromRawUnchecked"/>
    public static TransactionListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionListResponseFromRaw : IFromRawJson<TransactionListResponse>
{
    /// <inheritdoc/>
    public TransactionListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransactionListResponseIntersectionMember1,
        TransactionListResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransactionListResponseIntersectionMember1 : JsonModel
{
    public TransactionListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransactionListResponseIntersectionMember1Data>(
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

    public TransactionListResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionListResponseIntersectionMember1(
        TransactionListResponseIntersectionMember1 transactionListResponseIntersectionMember1
    )
        : base(transactionListResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransactionListResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionListResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionListResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransactionListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionListResponseIntersectionMember1FromRaw
    : IFromRawJson<TransactionListResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransactionListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionListResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransactionListResponseIntersectionMember1Data,
        TransactionListResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransactionListResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// List of transactions
    /// </summary>
    public required IReadOnlyList<TransactionListResponseIntersectionMember1DataData> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<TransactionListResponseIntersectionMember1DataData>
            >("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<TransactionListResponseIntersectionMember1DataData>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    public required global::Bila.Models.Transactions.Meta Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<global::Bila.Models.Transactions.Meta>("meta");
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

    public TransactionListResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionListResponseIntersectionMember1Data(
        TransactionListResponseIntersectionMember1Data transactionListResponseIntersectionMember1Data
    )
        : base(transactionListResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransactionListResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionListResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionListResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransactionListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionListResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransactionListResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransactionListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionListResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransactionListResponseIntersectionMember1DataData,
        TransactionListResponseIntersectionMember1DataDataFromRaw
    >)
)]
public sealed record class TransactionListResponseIntersectionMember1DataData : JsonModel
{
    /// <summary>
    /// Transaction UUID
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
    /// Account / wallet ID
    /// </summary>
    public required string AccountID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("accountId");
        }
        init { this._rawData.Set("accountId", value); }
    }

    /// <summary>
    /// Transaction amount
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
    /// Balance after transaction
    /// </summary>
    public required double BalanceAfter
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("balanceAfter");
        }
        init { this._rawData.Set("balanceAfter", value); }
    }

    /// <summary>
    /// Balance before transaction
    /// </summary>
    public required double BalanceBefore
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("balanceBefore");
        }
        init { this._rawData.Set("balanceBefore", value); }
    }

    /// <summary>
    /// Transaction timestamp
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
    /// Transaction status
    /// </summary>
    public required ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransactionListResponseIntersectionMember1DataDataStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transaction type
    /// </summary>
    public required ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransactionListResponseIntersectionMember1DataDataType>
            >("type");
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Transaction description
    /// </summary>
    public string? Description
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("description");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("description", value);
        }
    }

    /// <summary>
    /// Client reference
    /// </summary>
    public string? Reference
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("reference");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("reference", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.AccountID;
        _ = this.Amount;
        _ = this.BalanceAfter;
        _ = this.BalanceBefore;
        _ = this.CreatedAt;
        _ = this.Currency;
        this.Status.Validate();
        this.Type.Validate();
        _ = this.Description;
        _ = this.Reference;
    }

    public TransactionListResponseIntersectionMember1DataData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionListResponseIntersectionMember1DataData(
        TransactionListResponseIntersectionMember1DataData transactionListResponseIntersectionMember1DataData
    )
        : base(transactionListResponseIntersectionMember1DataData) { }
#pragma warning restore CS8618

    public TransactionListResponseIntersectionMember1DataData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionListResponseIntersectionMember1DataData(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionListResponseIntersectionMember1DataDataFromRaw.FromRawUnchecked"/>
    public static TransactionListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionListResponseIntersectionMember1DataDataFromRaw
    : IFromRawJson<TransactionListResponseIntersectionMember1DataData>
{
    /// <inheritdoc/>
    public TransactionListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionListResponseIntersectionMember1DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Transaction status
/// </summary>
[JsonConverter(typeof(TransactionListResponseIntersectionMember1DataDataStatusConverter))]
public enum TransactionListResponseIntersectionMember1DataDataStatus
{
    Pending,
    Successful,
    Failed,
    Cancelled,
}

sealed class TransactionListResponseIntersectionMember1DataDataStatusConverter
    : JsonConverter<TransactionListResponseIntersectionMember1DataDataStatus>
{
    public override TransactionListResponseIntersectionMember1DataDataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => TransactionListResponseIntersectionMember1DataDataStatus.Pending,
            "successful" => TransactionListResponseIntersectionMember1DataDataStatus.Successful,
            "failed" => TransactionListResponseIntersectionMember1DataDataStatus.Failed,
            "cancelled" => TransactionListResponseIntersectionMember1DataDataStatus.Cancelled,
            _ => (TransactionListResponseIntersectionMember1DataDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransactionListResponseIntersectionMember1DataDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransactionListResponseIntersectionMember1DataDataStatus.Pending => "pending",
                TransactionListResponseIntersectionMember1DataDataStatus.Successful => "successful",
                TransactionListResponseIntersectionMember1DataDataStatus.Failed => "failed",
                TransactionListResponseIntersectionMember1DataDataStatus.Cancelled => "cancelled",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Transaction type
/// </summary>
[JsonConverter(typeof(TransactionListResponseIntersectionMember1DataDataTypeConverter))]
public enum TransactionListResponseIntersectionMember1DataDataType
{
    Credit,
    Debit,
}

sealed class TransactionListResponseIntersectionMember1DataDataTypeConverter
    : JsonConverter<TransactionListResponseIntersectionMember1DataDataType>
{
    public override TransactionListResponseIntersectionMember1DataDataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "credit" => TransactionListResponseIntersectionMember1DataDataType.Credit,
            "debit" => TransactionListResponseIntersectionMember1DataDataType.Debit,
            _ => (TransactionListResponseIntersectionMember1DataDataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransactionListResponseIntersectionMember1DataDataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransactionListResponseIntersectionMember1DataDataType.Credit => "credit",
                TransactionListResponseIntersectionMember1DataDataType.Debit => "debit",
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
        global::Bila.Models.Transactions.Meta,
        global::Bila.Models.Transactions.MetaFromRaw
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
    public Meta(global::Bila.Models.Transactions.Meta meta)
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

    /// <inheritdoc cref="global::Bila.Models.Transactions.MetaFromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.Transactions.Meta FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MetaFromRaw : IFromRawJson<global::Bila.Models.Transactions.Meta>
{
    /// <inheritdoc/>
    public global::Bila.Models.Transactions.Meta FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.Transactions.Meta.FromRawUnchecked(rawData);
}
