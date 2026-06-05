using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using System = System;

namespace Bila.Models.Transactions;

[JsonConverter(typeof(JsonModelConverter<TransactionResponseDto, TransactionResponseDtoFromRaw>))]
public sealed record class TransactionResponseDto : JsonModel
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
    public required ApiEnum<string, Status> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, Status>>("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transaction type
    /// </summary>
    public required ApiEnum<string, TransactionResponseDtoType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, TransactionResponseDtoType>>(
                "type"
            );
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

    public TransactionResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionResponseDto(TransactionResponseDto transactionResponseDto)
        : base(transactionResponseDto) { }
#pragma warning restore CS8618

    public TransactionResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionResponseDtoFromRaw.FromRawUnchecked"/>
    public static TransactionResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionResponseDtoFromRaw : IFromRawJson<TransactionResponseDto>
{
    /// <inheritdoc/>
    public TransactionResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionResponseDto.FromRawUnchecked(rawData);
}

/// <summary>
/// Transaction status
/// </summary>
[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Pending,
    Successful,
    Failed,
    Cancelled,
}

sealed class StatusConverter : JsonConverter<Status>
{
    public override Status Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => Status.Pending,
            "successful" => Status.Successful,
            "failed" => Status.Failed,
            "cancelled" => Status.Cancelled,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Pending => "pending",
                Status.Successful => "successful",
                Status.Failed => "failed",
                Status.Cancelled => "cancelled",
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
[JsonConverter(typeof(TransactionResponseDtoTypeConverter))]
public enum TransactionResponseDtoType
{
    Credit,
    Debit,
}

sealed class TransactionResponseDtoTypeConverter : JsonConverter<TransactionResponseDtoType>
{
    public override TransactionResponseDtoType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "credit" => TransactionResponseDtoType.Credit,
            "debit" => TransactionResponseDtoType.Debit,
            _ => (TransactionResponseDtoType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransactionResponseDtoType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransactionResponseDtoType.Credit => "credit",
                TransactionResponseDtoType.Debit => "debit",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
