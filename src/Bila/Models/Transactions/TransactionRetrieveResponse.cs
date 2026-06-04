using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Accounts;
using System = System;

namespace Bila.Models.Transactions;

[JsonConverter(
    typeof(JsonModelConverter<TransactionRetrieveResponse, TransactionRetrieveResponseFromRaw>)
)]
public sealed record class TransactionRetrieveResponse : JsonModel
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

    public global::Bila.Models.Transactions.Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<global::Bila.Models.Transactions.Data>("data");
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
        TransactionRetrieveResponse transactionRetrieveResponse
    ) =>
        new()
        {
            Message = transactionRetrieveResponse.Message,
            Status = transactionRetrieveResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransactionRetrieveResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionRetrieveResponse(TransactionRetrieveResponse transactionRetrieveResponse)
        : base(transactionRetrieveResponse) { }
#pragma warning restore CS8618

    public TransactionRetrieveResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionRetrieveResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionRetrieveResponseFromRaw.FromRawUnchecked"/>
    public static TransactionRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionRetrieveResponseFromRaw : IFromRawJson<TransactionRetrieveResponse>
{
    /// <inheritdoc/>
    public TransactionRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionRetrieveResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::Bila.Models.Transactions.IntersectionMember1,
        global::Bila.Models.Transactions.IntersectionMember1FromRaw
    >)
)]
public sealed record class IntersectionMember1 : JsonModel
{
    public global::Bila.Models.Transactions.Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<global::Bila.Models.Transactions.Data>("data");
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

    public IntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public IntersectionMember1(
        global::Bila.Models.Transactions.IntersectionMember1 intersectionMember1
    )
        : base(intersectionMember1) { }
#pragma warning restore CS8618

    public IntersectionMember1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    IntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="global::Bila.Models.Transactions.IntersectionMember1FromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.Transactions.IntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class IntersectionMember1FromRaw
    : IFromRawJson<global::Bila.Models.Transactions.IntersectionMember1>
{
    /// <inheritdoc/>
    public global::Bila.Models.Transactions.IntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.Transactions.IntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::Bila.Models.Transactions.Data,
        global::Bila.Models.Transactions.DataFromRaw
    >)
)]
public sealed record class Data : JsonModel
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
    public required ApiEnum<string, global::Bila.Models.Transactions.Status> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, global::Bila.Models.Transactions.Status>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transaction type
    /// </summary>
    public required ApiEnum<string, DataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, DataType>>("type");
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

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(global::Bila.Models.Transactions.Data data)
        : base(data) { }
#pragma warning restore CS8618

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="global::Bila.Models.Transactions.DataFromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.Transactions.Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<global::Bila.Models.Transactions.Data>
{
    /// <inheritdoc/>
    public global::Bila.Models.Transactions.Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.Transactions.Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Transaction status
/// </summary>
[JsonConverter(typeof(global::Bila.Models.Transactions.StatusConverter))]
public enum Status
{
    Pending,
    Successful,
    Failed,
    Cancelled,
}

sealed class StatusConverter : JsonConverter<global::Bila.Models.Transactions.Status>
{
    public override global::Bila.Models.Transactions.Status Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => global::Bila.Models.Transactions.Status.Pending,
            "successful" => global::Bila.Models.Transactions.Status.Successful,
            "failed" => global::Bila.Models.Transactions.Status.Failed,
            "cancelled" => global::Bila.Models.Transactions.Status.Cancelled,
            _ => (global::Bila.Models.Transactions.Status)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Bila.Models.Transactions.Status value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Bila.Models.Transactions.Status.Pending => "pending",
                global::Bila.Models.Transactions.Status.Successful => "successful",
                global::Bila.Models.Transactions.Status.Failed => "failed",
                global::Bila.Models.Transactions.Status.Cancelled => "cancelled",
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
[JsonConverter(typeof(DataTypeConverter))]
public enum DataType
{
    Credit,
    Debit,
}

sealed class DataTypeConverter : JsonConverter<DataType>
{
    public override DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "credit" => DataType.Credit,
            "debit" => DataType.Debit,
            _ => (DataType)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, DataType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                DataType.Credit => "credit",
                DataType.Debit => "debit",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
