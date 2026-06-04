using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using Accounts = Bila.Models.Accounts;

namespace Bila.Models.Collections;

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionGetStatusByReferenceResponse,
        CollectionGetStatusByReferenceResponseFromRaw
    >)
)]
public sealed record class CollectionGetStatusByReferenceResponse : JsonModel
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

    public CollectionGetStatusByReferenceResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CollectionGetStatusByReferenceResponseIntersectionMember1Data>(
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

    public static implicit operator Accounts::BilaResponse(
        CollectionGetStatusByReferenceResponse collectionGetStatusByReferenceResponse
    ) =>
        new()
        {
            Message = collectionGetStatusByReferenceResponse.Message,
            Status = collectionGetStatusByReferenceResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public CollectionGetStatusByReferenceResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionGetStatusByReferenceResponse(
        CollectionGetStatusByReferenceResponse collectionGetStatusByReferenceResponse
    )
        : base(collectionGetStatusByReferenceResponse) { }
#pragma warning restore CS8618

    public CollectionGetStatusByReferenceResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionGetStatusByReferenceResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionGetStatusByReferenceResponseFromRaw.FromRawUnchecked"/>
    public static CollectionGetStatusByReferenceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionGetStatusByReferenceResponseFromRaw
    : IFromRawJson<CollectionGetStatusByReferenceResponse>
{
    /// <inheritdoc/>
    public CollectionGetStatusByReferenceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionGetStatusByReferenceResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionGetStatusByReferenceResponseIntersectionMember1,
        CollectionGetStatusByReferenceResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class CollectionGetStatusByReferenceResponseIntersectionMember1 : JsonModel
{
    public CollectionGetStatusByReferenceResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CollectionGetStatusByReferenceResponseIntersectionMember1Data>(
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

    public CollectionGetStatusByReferenceResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionGetStatusByReferenceResponseIntersectionMember1(
        CollectionGetStatusByReferenceResponseIntersectionMember1 collectionGetStatusByReferenceResponseIntersectionMember1
    )
        : base(collectionGetStatusByReferenceResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public CollectionGetStatusByReferenceResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionGetStatusByReferenceResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionGetStatusByReferenceResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static CollectionGetStatusByReferenceResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionGetStatusByReferenceResponseIntersectionMember1FromRaw
    : IFromRawJson<CollectionGetStatusByReferenceResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public CollectionGetStatusByReferenceResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionGetStatusByReferenceResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionGetStatusByReferenceResponseIntersectionMember1Data,
        CollectionGetStatusByReferenceResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class CollectionGetStatusByReferenceResponseIntersectionMember1Data : JsonModel
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
    public required CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer Customer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer>(
                "customer"
            );
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
    public required ApiEnum<
        string,
        CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus
    > Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus>
            >("status");
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
    /// Who bears the collection platform fee
    /// </summary>
    public ApiEnum<
        string,
        CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer
    >? FeeBearer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<
                    string,
                    CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer
                >
            >("feeBearer");
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

    public CollectionGetStatusByReferenceResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionGetStatusByReferenceResponseIntersectionMember1Data(
        CollectionGetStatusByReferenceResponseIntersectionMember1Data collectionGetStatusByReferenceResponseIntersectionMember1Data
    )
        : base(collectionGetStatusByReferenceResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public CollectionGetStatusByReferenceResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionGetStatusByReferenceResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionGetStatusByReferenceResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static CollectionGetStatusByReferenceResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionGetStatusByReferenceResponseIntersectionMember1DataFromRaw
    : IFromRawJson<CollectionGetStatusByReferenceResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public CollectionGetStatusByReferenceResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionGetStatusByReferenceResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Customer details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer,
        CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomerFromRaw
    >)
)]
public sealed record class CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer
    : JsonModel
{
    /// <summary>
    /// Customer name
    /// </summary>
    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    /// <summary>
    /// Mobile money operator
    /// </summary>
    public required string Operator
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("operator");
        }
        init { this._rawData.Set("operator", value); }
    }

    /// <summary>
    /// Customer phone number
    /// </summary>
    public required string Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("phone");
        }
        init { this._rawData.Set("phone", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Name;
        _ = this.Operator;
        _ = this.Phone;
    }

    public CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer(
        CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer collectionGetStatusByReferenceResponseIntersectionMember1DataCustomer
    )
        : base(collectionGetStatusByReferenceResponseIntersectionMember1DataCustomer) { }
#pragma warning restore CS8618

    public CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomerFromRaw.FromRawUnchecked"/>
    public static CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomerFromRaw
    : IFromRawJson<CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer>
{
    /// <inheritdoc/>
    public CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CollectionGetStatusByReferenceResponseIntersectionMember1DataCustomer.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Collection status
/// </summary>
[JsonConverter(
    typeof(CollectionGetStatusByReferenceResponseIntersectionMember1DataStatusConverter)
)]
public enum CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus
{
    Pending,
    Successful,
    Failed,
    OtpRequired,
    PayOffline,
}

sealed class CollectionGetStatusByReferenceResponseIntersectionMember1DataStatusConverter
    : JsonConverter<CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus>
{
    public override CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" =>
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.Pending,
            "successful" =>
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.Successful,
            "failed" => CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.Failed,
            "otp-required" =>
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.OtpRequired,
            "pay-offline" =>
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.PayOffline,
            _ => (CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.Pending =>
                    "pending",
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.Successful =>
                    "successful",
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.Failed =>
                    "failed",
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.OtpRequired =>
                    "otp-required",
                CollectionGetStatusByReferenceResponseIntersectionMember1DataStatus.PayOffline =>
                    "pay-offline",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Who bears the collection platform fee
/// </summary>
[JsonConverter(
    typeof(CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearerConverter)
)]
public enum CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer
{
    Merchant,
    Customer,
}

sealed class CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearerConverter
    : JsonConverter<CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer>
{
    public override CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "merchant" =>
                CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer.Merchant,
            "customer" =>
                CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer.Customer,
            _ => (CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer.Merchant =>
                    "merchant",
                CollectionGetStatusByReferenceResponseIntersectionMember1DataFeeBearer.Customer =>
                    "customer",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
