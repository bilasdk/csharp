using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using Accounts = Bila.Models.Accounts;

namespace Bila.Models.Collections;

[JsonConverter(typeof(JsonModelConverter<CollectionListResponse, CollectionListResponseFromRaw>))]
public sealed record class CollectionListResponse : JsonModel
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

    public CollectionListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CollectionListResponseIntersectionMember1Data>(
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
        CollectionListResponse collectionListResponse
    ) => new() { Message = collectionListResponse.Message, Status = collectionListResponse.Status };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public CollectionListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionListResponse(CollectionListResponse collectionListResponse)
        : base(collectionListResponse) { }
#pragma warning restore CS8618

    public CollectionListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionListResponseFromRaw.FromRawUnchecked"/>
    public static CollectionListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionListResponseFromRaw : IFromRawJson<CollectionListResponse>
{
    /// <inheritdoc/>
    public CollectionListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionListResponseIntersectionMember1,
        CollectionListResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class CollectionListResponseIntersectionMember1 : JsonModel
{
    public CollectionListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<CollectionListResponseIntersectionMember1Data>(
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

    public CollectionListResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionListResponseIntersectionMember1(
        CollectionListResponseIntersectionMember1 collectionListResponseIntersectionMember1
    )
        : base(collectionListResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public CollectionListResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionListResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionListResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static CollectionListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionListResponseIntersectionMember1FromRaw
    : IFromRawJson<CollectionListResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public CollectionListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionListResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionListResponseIntersectionMember1Data,
        CollectionListResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class CollectionListResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// List of collections
    /// </summary>
    public required IReadOnlyList<CollectionListResponseIntersectionMember1DataData> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<CollectionListResponseIntersectionMember1DataData>
            >("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<CollectionListResponseIntersectionMember1DataData>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    public required Meta Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<Meta>("meta");
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

    public CollectionListResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionListResponseIntersectionMember1Data(
        CollectionListResponseIntersectionMember1Data collectionListResponseIntersectionMember1Data
    )
        : base(collectionListResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public CollectionListResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionListResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionListResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static CollectionListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionListResponseIntersectionMember1DataFromRaw
    : IFromRawJson<CollectionListResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public CollectionListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionListResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionListResponseIntersectionMember1DataData,
        CollectionListResponseIntersectionMember1DataDataFromRaw
    >)
)]
public sealed record class CollectionListResponseIntersectionMember1DataData : JsonModel
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
    public required CollectionListResponseIntersectionMember1DataDataCustomer Customer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<CollectionListResponseIntersectionMember1DataDataCustomer>(
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
    public required ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, CollectionListResponseIntersectionMember1DataDataStatus>
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
    public ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer>? FeeBearer
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<
                ApiEnum<string, CollectionListResponseIntersectionMember1DataDataFeeBearer>
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

    public CollectionListResponseIntersectionMember1DataData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionListResponseIntersectionMember1DataData(
        CollectionListResponseIntersectionMember1DataData collectionListResponseIntersectionMember1DataData
    )
        : base(collectionListResponseIntersectionMember1DataData) { }
#pragma warning restore CS8618

    public CollectionListResponseIntersectionMember1DataData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionListResponseIntersectionMember1DataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionListResponseIntersectionMember1DataDataFromRaw.FromRawUnchecked"/>
    public static CollectionListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionListResponseIntersectionMember1DataDataFromRaw
    : IFromRawJson<CollectionListResponseIntersectionMember1DataData>
{
    /// <inheritdoc/>
    public CollectionListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionListResponseIntersectionMember1DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Customer details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        CollectionListResponseIntersectionMember1DataDataCustomer,
        CollectionListResponseIntersectionMember1DataDataCustomerFromRaw
    >)
)]
public sealed record class CollectionListResponseIntersectionMember1DataDataCustomer : JsonModel
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

    public CollectionListResponseIntersectionMember1DataDataCustomer() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionListResponseIntersectionMember1DataDataCustomer(
        CollectionListResponseIntersectionMember1DataDataCustomer collectionListResponseIntersectionMember1DataDataCustomer
    )
        : base(collectionListResponseIntersectionMember1DataDataCustomer) { }
#pragma warning restore CS8618

    public CollectionListResponseIntersectionMember1DataDataCustomer(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionListResponseIntersectionMember1DataDataCustomer(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionListResponseIntersectionMember1DataDataCustomerFromRaw.FromRawUnchecked"/>
    public static CollectionListResponseIntersectionMember1DataDataCustomer FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionListResponseIntersectionMember1DataDataCustomerFromRaw
    : IFromRawJson<CollectionListResponseIntersectionMember1DataDataCustomer>
{
    /// <inheritdoc/>
    public CollectionListResponseIntersectionMember1DataDataCustomer FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionListResponseIntersectionMember1DataDataCustomer.FromRawUnchecked(rawData);
}

/// <summary>
/// Collection status
/// </summary>
[JsonConverter(typeof(CollectionListResponseIntersectionMember1DataDataStatusConverter))]
public enum CollectionListResponseIntersectionMember1DataDataStatus
{
    Pending,
    Successful,
    Failed,
    OtpRequired,
    PayOffline,
}

sealed class CollectionListResponseIntersectionMember1DataDataStatusConverter
    : JsonConverter<CollectionListResponseIntersectionMember1DataDataStatus>
{
    public override CollectionListResponseIntersectionMember1DataDataStatus Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "pending" => CollectionListResponseIntersectionMember1DataDataStatus.Pending,
            "successful" => CollectionListResponseIntersectionMember1DataDataStatus.Successful,
            "failed" => CollectionListResponseIntersectionMember1DataDataStatus.Failed,
            "otp-required" => CollectionListResponseIntersectionMember1DataDataStatus.OtpRequired,
            "pay-offline" => CollectionListResponseIntersectionMember1DataDataStatus.PayOffline,
            _ => (CollectionListResponseIntersectionMember1DataDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CollectionListResponseIntersectionMember1DataDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CollectionListResponseIntersectionMember1DataDataStatus.Pending => "pending",
                CollectionListResponseIntersectionMember1DataDataStatus.Successful => "successful",
                CollectionListResponseIntersectionMember1DataDataStatus.Failed => "failed",
                CollectionListResponseIntersectionMember1DataDataStatus.OtpRequired =>
                    "otp-required",
                CollectionListResponseIntersectionMember1DataDataStatus.PayOffline => "pay-offline",
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
[JsonConverter(typeof(CollectionListResponseIntersectionMember1DataDataFeeBearerConverter))]
public enum CollectionListResponseIntersectionMember1DataDataFeeBearer
{
    Merchant,
    Customer,
}

sealed class CollectionListResponseIntersectionMember1DataDataFeeBearerConverter
    : JsonConverter<CollectionListResponseIntersectionMember1DataDataFeeBearer>
{
    public override CollectionListResponseIntersectionMember1DataDataFeeBearer Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "merchant" => CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant,
            "customer" => CollectionListResponseIntersectionMember1DataDataFeeBearer.Customer,
            _ => (CollectionListResponseIntersectionMember1DataDataFeeBearer)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        CollectionListResponseIntersectionMember1DataDataFeeBearer value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                CollectionListResponseIntersectionMember1DataDataFeeBearer.Merchant => "merchant",
                CollectionListResponseIntersectionMember1DataDataFeeBearer.Customer => "customer",
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
[JsonConverter(typeof(JsonModelConverter<Meta, MetaFromRaw>))]
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
    public Meta(Meta meta)
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

    /// <inheritdoc cref="MetaFromRaw.FromRawUnchecked"/>
    public static Meta FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MetaFromRaw : IFromRawJson<Meta>
{
    /// <inheritdoc/>
    public Meta FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Meta.FromRawUnchecked(rawData);
}
