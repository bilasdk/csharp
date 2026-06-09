using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;
using Usebila.Exceptions;
using System = System;

namespace Usebila.Models.Transfers;

[JsonConverter(typeof(JsonModelConverter<TransferResponseDto, TransferResponseDtoFromRaw>))]
public sealed record class TransferResponseDto : JsonModel
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
    public required TransferRecipientDto Recipient
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<TransferRecipientDto>("recipient");
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
    public required ApiEnum<string, TransferResponseDtoStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, TransferResponseDtoStatus>>(
                "status"
            );
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Transfer recipient type
    /// </summary>
    public required ApiEnum<string, TransferResponseDtoType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, TransferResponseDtoType>>("type");
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

    public TransferResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferResponseDto(TransferResponseDto transferResponseDto)
        : base(transferResponseDto) { }
#pragma warning restore CS8618

    public TransferResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferResponseDtoFromRaw.FromRawUnchecked"/>
    public static TransferResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferResponseDtoFromRaw : IFromRawJson<TransferResponseDto>
{
    /// <inheritdoc/>
    public TransferResponseDto FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        TransferResponseDto.FromRawUnchecked(rawData);
}

/// <summary>
/// Transfer status
/// </summary>
[JsonConverter(typeof(TransferResponseDtoStatusConverter))]
public enum TransferResponseDtoStatus
{
    Pending,
    Successful,
    Failed,
}

sealed class TransferResponseDtoStatusConverter : JsonConverter<TransferResponseDtoStatus>
{
    public override TransferResponseDtoStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => TransferResponseDtoStatus.Pending,
            "successful" => TransferResponseDtoStatus.Successful,
            "failed" => TransferResponseDtoStatus.Failed,
            _ => (TransferResponseDtoStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferResponseDtoStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferResponseDtoStatus.Pending => "pending",
                TransferResponseDtoStatus.Successful => "successful",
                TransferResponseDtoStatus.Failed => "failed",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Transfer recipient type
/// </summary>
[JsonConverter(typeof(TransferResponseDtoTypeConverter))]
public enum TransferResponseDtoType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferResponseDtoTypeConverter : JsonConverter<TransferResponseDtoType>
{
    public override TransferResponseDtoType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" => TransferResponseDtoType.BankAccount,
            "mobile-money" => TransferResponseDtoType.MobileMoney,
            _ => (TransferResponseDtoType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferResponseDtoType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferResponseDtoType.BankAccount => "bank-account",
                TransferResponseDtoType.MobileMoney => "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
