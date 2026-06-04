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

namespace Bila.Models.TransferRecipients;

[JsonConverter(
    typeof(JsonModelConverter<TransferRecipientListResponse, TransferRecipientListResponseFromRaw>)
)]
public sealed record class TransferRecipientListResponse : JsonModel
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

    public TransferRecipientListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferRecipientListResponseIntersectionMember1Data>(
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
        TransferRecipientListResponse transferRecipientListResponse
    ) =>
        new()
        {
            Message = transferRecipientListResponse.Message,
            Status = transferRecipientListResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransferRecipientListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientListResponse(
        TransferRecipientListResponse transferRecipientListResponse
    )
        : base(transferRecipientListResponse) { }
#pragma warning restore CS8618

    public TransferRecipientListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientListResponseFromRaw.FromRawUnchecked"/>
    public static TransferRecipientListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientListResponseFromRaw : IFromRawJson<TransferRecipientListResponse>
{
    /// <inheritdoc/>
    public TransferRecipientListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientListResponseIntersectionMember1,
        TransferRecipientListResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferRecipientListResponseIntersectionMember1 : JsonModel
{
    public TransferRecipientListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferRecipientListResponseIntersectionMember1Data>(
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

    public TransferRecipientListResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientListResponseIntersectionMember1(
        TransferRecipientListResponseIntersectionMember1 transferRecipientListResponseIntersectionMember1
    )
        : base(transferRecipientListResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferRecipientListResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientListResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientListResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferRecipientListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientListResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferRecipientListResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferRecipientListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientListResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientListResponseIntersectionMember1Data,
        TransferRecipientListResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferRecipientListResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// List of recipients
    /// </summary>
    public required IReadOnlyList<TransferRecipientListResponseIntersectionMember1DataData> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<TransferRecipientListResponseIntersectionMember1DataData>
            >("data");
        }
        init
        {
            this._rawData.Set<
                ImmutableArray<TransferRecipientListResponseIntersectionMember1DataData>
            >("data", ImmutableArray.ToImmutableArray(value));
        }
    }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    public required global::Bila.Models.TransferRecipients.Meta Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<global::Bila.Models.TransferRecipients.Meta>(
                "meta"
            );
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

    public TransferRecipientListResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientListResponseIntersectionMember1Data(
        TransferRecipientListResponseIntersectionMember1Data transferRecipientListResponseIntersectionMember1Data
    )
        : base(transferRecipientListResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferRecipientListResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientListResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientListResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferRecipientListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientListResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferRecipientListResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferRecipientListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientListResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientListResponseIntersectionMember1DataData,
        TransferRecipientListResponseIntersectionMember1DataDataFromRaw
    >)
)]
public sealed record class TransferRecipientListResponseIntersectionMember1DataData : JsonModel
{
    /// <summary>
    /// Recipient UUID
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
    /// Account holder name
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
    /// Country code
    /// </summary>
    public required string Country
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("country");
        }
        init { this._rawData.Set("country", value); }
    }

    /// <summary>
    /// Creation timestamp
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
    /// Recipient type
    /// </summary>
    public required ApiEnum<
        string,
        TransferRecipientListResponseIntersectionMember1DataDataType
    > Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, TransferRecipientListResponseIntersectionMember1DataDataType>
            >("type");
        }
        init { this._rawData.Set("type", value); }
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
    /// Bank ID (bank-account only)
    /// </summary>
    public string? BankID
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("bankId");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("bankId", value);
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
        _ = this.ID;
        _ = this.AccountName;
        _ = this.Country;
        _ = this.CreatedAt;
        this.Type.Validate();
        _ = this.AccountNumber;
        _ = this.BankID;
        _ = this.BankName;
        _ = this.Operator;
        _ = this.Phone;
    }

    public TransferRecipientListResponseIntersectionMember1DataData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientListResponseIntersectionMember1DataData(
        TransferRecipientListResponseIntersectionMember1DataData transferRecipientListResponseIntersectionMember1DataData
    )
        : base(transferRecipientListResponseIntersectionMember1DataData) { }
#pragma warning restore CS8618

    public TransferRecipientListResponseIntersectionMember1DataData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientListResponseIntersectionMember1DataData(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientListResponseIntersectionMember1DataDataFromRaw.FromRawUnchecked"/>
    public static TransferRecipientListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientListResponseIntersectionMember1DataDataFromRaw
    : IFromRawJson<TransferRecipientListResponseIntersectionMember1DataData>
{
    /// <inheritdoc/>
    public TransferRecipientListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientListResponseIntersectionMember1DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Recipient type
/// </summary>
[JsonConverter(typeof(TransferRecipientListResponseIntersectionMember1DataDataTypeConverter))]
public enum TransferRecipientListResponseIntersectionMember1DataDataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferRecipientListResponseIntersectionMember1DataDataTypeConverter
    : JsonConverter<TransferRecipientListResponseIntersectionMember1DataDataType>
{
    public override TransferRecipientListResponseIntersectionMember1DataDataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" =>
                TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount,
            "mobile-money" =>
                TransferRecipientListResponseIntersectionMember1DataDataType.MobileMoney,
            _ => (TransferRecipientListResponseIntersectionMember1DataDataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferRecipientListResponseIntersectionMember1DataDataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferRecipientListResponseIntersectionMember1DataDataType.BankAccount =>
                    "bank-account",
                TransferRecipientListResponseIntersectionMember1DataDataType.MobileMoney =>
                    "mobile-money",
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
        global::Bila.Models.TransferRecipients.Meta,
        global::Bila.Models.TransferRecipients.MetaFromRaw
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
    public Meta(global::Bila.Models.TransferRecipients.Meta meta)
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

    /// <inheritdoc cref="global::Bila.Models.TransferRecipients.MetaFromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.TransferRecipients.Meta FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class MetaFromRaw : IFromRawJson<global::Bila.Models.TransferRecipients.Meta>
{
    /// <inheritdoc/>
    public global::Bila.Models.TransferRecipients.Meta FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.TransferRecipients.Meta.FromRawUnchecked(rawData);
}
