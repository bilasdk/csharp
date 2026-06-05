using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;

namespace Bila.Models.Collections;

[JsonConverter(
    typeof(JsonModelConverter<BilaCollectionResponseDto, BilaCollectionResponseDtoFromRaw>)
)]
public sealed record class BilaCollectionResponseDto : JsonModel
{
    /// <summary>
    /// Collection ID
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
    /// Collection amount
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
    /// Collection creation timestamp
    /// </summary>
    public required DateTimeOffset CreatedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<DateTimeOffset>("createdAt");
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
    /// Customer details
    /// </summary>
    public required BilaCollectionCustomerDto Customer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<BilaCollectionCustomerDto>("customer");
        }
        init { this._rawData.Set("customer", value); }
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
    /// Collection status
    /// </summary>
    public required ApiEnum<string, BilaCollectionResponseDtoStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, BilaCollectionResponseDtoStatus>>(
                "status"
            );
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Collection completion timestamp
    /// </summary>
    public DateTimeOffset? CompletedAt
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableStruct<DateTimeOffset>("completedAt");
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
    /// Who bears the transaction fee
    /// </summary>
    public ApiEnum<string, FeeBearer>? FeeBearer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ApiEnum<string, FeeBearer>>("feeBearer");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("feeBearer", value);
        }
    }

    /// <summary>
    /// Collection narration
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
        this.Customer.Validate();
        _ = this.Reference;
        this.Status.Validate();
        _ = this.CompletedAt;
        this.FeeBearer?.Validate();
        _ = this.Narration;
    }

    public BilaCollectionResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public BilaCollectionResponseDto(BilaCollectionResponseDto bilaCollectionResponseDto)
        : base(bilaCollectionResponseDto) { }
#pragma warning restore CS8618

    public BilaCollectionResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BilaCollectionResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BilaCollectionResponseDtoFromRaw.FromRawUnchecked"/>
    public static BilaCollectionResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BilaCollectionResponseDtoFromRaw : IFromRawJson<BilaCollectionResponseDto>
{
    /// <inheritdoc/>
    public BilaCollectionResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => BilaCollectionResponseDto.FromRawUnchecked(rawData);
}

/// <summary>
/// Collection status
/// </summary>
[JsonConverter(typeof(BilaCollectionResponseDtoStatusConverter))]
public enum BilaCollectionResponseDtoStatus
{
    Pending,
    Successful,
    Failed,
    OtpRequired,
    PayOffline,
}

sealed class BilaCollectionResponseDtoStatusConverter
    : JsonConverter<BilaCollectionResponseDtoStatus>
{
    public override BilaCollectionResponseDtoStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => BilaCollectionResponseDtoStatus.Pending,
            "successful" => BilaCollectionResponseDtoStatus.Successful,
            "failed" => BilaCollectionResponseDtoStatus.Failed,
            "otp-required" => BilaCollectionResponseDtoStatus.OtpRequired,
            "pay-offline" => BilaCollectionResponseDtoStatus.PayOffline,
            _ => (BilaCollectionResponseDtoStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        BilaCollectionResponseDtoStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                BilaCollectionResponseDtoStatus.Pending => "pending",
                BilaCollectionResponseDtoStatus.Successful => "successful",
                BilaCollectionResponseDtoStatus.Failed => "failed",
                BilaCollectionResponseDtoStatus.OtpRequired => "otp-required",
                BilaCollectionResponseDtoStatus.PayOffline => "pay-offline",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Who bears the transaction fee
/// </summary>
[JsonConverter(typeof(FeeBearerConverter))]
public enum FeeBearer
{
    Merchant,
    Customer,
}

sealed class FeeBearerConverter : JsonConverter<FeeBearer>
{
    public override FeeBearer Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "merchant" => FeeBearer.Merchant,
            "customer" => FeeBearer.Customer,
            _ => (FeeBearer)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        FeeBearer value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                FeeBearer.Merchant => "merchant",
                FeeBearer.Customer => "customer",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
