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
        CollectionInitiateMobileMoneyCollectionResponse,
        CollectionInitiateMobileMoneyCollectionResponseFromRaw
    >)
)]
public sealed record class CollectionInitiateMobileMoneyCollectionResponse : JsonModel
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

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data>(
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
        CollectionInitiateMobileMoneyCollectionResponse collectionInitiateMobileMoneyCollectionResponse
    ) =>
        new()
        {
            Message = collectionInitiateMobileMoneyCollectionResponse.Message,
            Status = collectionInitiateMobileMoneyCollectionResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public CollectionInitiateMobileMoneyCollectionResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionInitiateMobileMoneyCollectionResponse(
        CollectionInitiateMobileMoneyCollectionResponse collectionInitiateMobileMoneyCollectionResponse
    )
        : base(collectionInitiateMobileMoneyCollectionResponse) { }
#pragma warning restore CS8618

    public CollectionInitiateMobileMoneyCollectionResponse(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionInitiateMobileMoneyCollectionResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionInitiateMobileMoneyCollectionResponseFromRaw.FromRawUnchecked"/>
    public static CollectionInitiateMobileMoneyCollectionResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionInitiateMobileMoneyCollectionResponseFromRaw
    : IFromRawJson<CollectionInitiateMobileMoneyCollectionResponse>
{
    /// <inheritdoc/>
    public CollectionInitiateMobileMoneyCollectionResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionInitiateMobileMoneyCollectionResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1,
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1
    : JsonModel
{
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data>(
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

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1(
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1 collectionInitiateMobileMoneyCollectionResponseIntersectionMember1
    )
        : base(collectionInitiateMobileMoneyCollectionResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1FromRaw
    : IFromRawJson<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1.FromRawUnchecked(
            rawData
        );
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data,
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data
    : JsonModel
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
    public required CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer Customer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer>(
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
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus
    > Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<
                    string,
                    CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus
                >
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
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer
    >? FeeBearer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<
                    string,
                    CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer
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

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data(
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data collectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data
    )
        : base(collectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFromRaw
    : IFromRawJson<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1Data.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Customer details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer,
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomerFromRaw
    >)
)]
public sealed record class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer
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

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer(
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer collectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer
    )
        : base(collectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer) { }
#pragma warning restore CS8618

    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomerFromRaw.FromRawUnchecked"/>
    public static CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomerFromRaw
    : IFromRawJson<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer>
{
    /// <inheritdoc/>
    public CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataCustomer.FromRawUnchecked(
            rawData
        );
}

/// <summary>
/// Collection status
/// </summary>
[JsonConverter(
    typeof(CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatusConverter)
)]
public enum CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus
{
    Pending,
    Successful,
    Failed,
    OtpRequired,
    PayOffline,
}

sealed class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatusConverter
    : JsonConverter<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus>
{
    public override CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.Pending,
            "successful" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.Successful,
            "failed" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.Failed,
            "otp-required" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.OtpRequired,
            "pay-offline" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.PayOffline,
            _ => (CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.Pending =>
                    "pending",
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.Successful =>
                    "successful",
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.Failed =>
                    "failed",
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.OtpRequired =>
                    "otp-required",
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataStatus.PayOffline =>
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
    typeof(CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearerConverter)
)]
public enum CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer
{
    Merchant,
    Customer,
}

sealed class CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearerConverter
    : JsonConverter<CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer>
{
    public override CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "merchant" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer.Merchant,
            "customer" =>
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer.Customer,
            _ => (CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer)(
                -1
            ),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer.Merchant =>
                    "merchant",
                CollectionInitiateMobileMoneyCollectionResponseIntersectionMember1DataFeeBearer.Customer =>
                    "customer",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
