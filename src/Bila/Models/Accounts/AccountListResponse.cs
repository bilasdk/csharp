using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using System = System;

namespace Bila.Models.Accounts;

[JsonConverter(typeof(JsonModelConverter<AccountListResponse, AccountListResponseFromRaw>))]
public sealed record class AccountListResponse : JsonModel
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

    public AccountListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountListResponseIntersectionMember1Data>(
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

    public static implicit operator BilaResponse(AccountListResponse accountListResponse) =>
        new() { Message = accountListResponse.Message, Status = accountListResponse.Status };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public AccountListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountListResponse(AccountListResponse accountListResponse)
        : base(accountListResponse) { }
#pragma warning restore CS8618

    public AccountListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountListResponseFromRaw.FromRawUnchecked"/>
    public static AccountListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountListResponseFromRaw : IFromRawJson<AccountListResponse>
{
    /// <inheritdoc/>
    public AccountListResponse FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountListResponseIntersectionMember1,
        AccountListResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class AccountListResponseIntersectionMember1 : JsonModel
{
    public AccountListResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountListResponseIntersectionMember1Data>(
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

    public AccountListResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountListResponseIntersectionMember1(
        AccountListResponseIntersectionMember1 accountListResponseIntersectionMember1
    )
        : base(accountListResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public AccountListResponseIntersectionMember1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountListResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountListResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static AccountListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountListResponseIntersectionMember1FromRaw
    : IFromRawJson<AccountListResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public AccountListResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountListResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountListResponseIntersectionMember1Data,
        AccountListResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class AccountListResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// List of accounts
    /// </summary>
    public required IReadOnlyList<AccountListResponseIntersectionMember1DataData> Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<
                ImmutableArray<AccountListResponseIntersectionMember1DataData>
            >("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<AccountListResponseIntersectionMember1DataData>>(
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

    public AccountListResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountListResponseIntersectionMember1Data(
        AccountListResponseIntersectionMember1Data accountListResponseIntersectionMember1Data
    )
        : base(accountListResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public AccountListResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountListResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountListResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static AccountListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountListResponseIntersectionMember1DataFromRaw
    : IFromRawJson<AccountListResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public AccountListResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountListResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountListResponseIntersectionMember1DataData,
        AccountListResponseIntersectionMember1DataDataFromRaw
    >)
)]
public sealed record class AccountListResponseIntersectionMember1DataData : JsonModel
{
    /// <summary>
    /// Account UUID
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
    /// Account creation timestamp
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
    /// Account details
    /// </summary>
    public required AccountListResponseIntersectionMember1DataDataDetails Details
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountListResponseIntersectionMember1DataDataDetails>(
                "details"
            );
        }
        init { this._rawData.Set("details", value); }
    }

    /// <summary>
    /// Account status
    /// </summary>
    public required ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus> Status
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, AccountListResponseIntersectionMember1DataDataStatus>
            >("status");
        }
        init { this._rawData.Set("status", value); }
    }

    /// <summary>
    /// Account type
    /// </summary>
    public required ApiEnum<string, AccountListResponseIntersectionMember1DataDataType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, AccountListResponseIntersectionMember1DataDataType>
            >("type");
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Available balance
    /// </summary>
    public string? AvailableBalance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("availableBalance");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("availableBalance", value);
        }
    }

    /// <summary>
    /// Ledger balance
    /// </summary>
    public string? LedgerBalance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("ledgerBalance");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("ledgerBalance", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.ID;
        _ = this.CreatedAt;
        _ = this.Currency;
        this.Details.Validate();
        this.Status.Validate();
        this.Type.Validate();
        _ = this.AvailableBalance;
        _ = this.LedgerBalance;
    }

    public AccountListResponseIntersectionMember1DataData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountListResponseIntersectionMember1DataData(
        AccountListResponseIntersectionMember1DataData accountListResponseIntersectionMember1DataData
    )
        : base(accountListResponseIntersectionMember1DataData) { }
#pragma warning restore CS8618

    public AccountListResponseIntersectionMember1DataData(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountListResponseIntersectionMember1DataData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountListResponseIntersectionMember1DataDataFromRaw.FromRawUnchecked"/>
    public static AccountListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountListResponseIntersectionMember1DataDataFromRaw
    : IFromRawJson<AccountListResponseIntersectionMember1DataData>
{
    /// <inheritdoc/>
    public AccountListResponseIntersectionMember1DataData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountListResponseIntersectionMember1DataData.FromRawUnchecked(rawData);
}

/// <summary>
/// Account details
/// </summary>
[JsonConverter(
    typeof(JsonModelConverter<
        AccountListResponseIntersectionMember1DataDataDetails,
        AccountListResponseIntersectionMember1DataDataDetailsFromRaw
    >)
)]
public sealed record class AccountListResponseIntersectionMember1DataDataDetails : JsonModel
{
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
    /// Account detail type
    /// </summary>
    public required string Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("type");
        }
        init { this._rawData.Set("type", value); }
    }

    /// <summary>
    /// Till number (for mobile money)
    /// </summary>
    public string? TillNumber
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<string>("tillNumber");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawData.Set("tillNumber", value);
        }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AccountName;
        _ = this.Type;
        _ = this.TillNumber;
    }

    public AccountListResponseIntersectionMember1DataDataDetails() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountListResponseIntersectionMember1DataDataDetails(
        AccountListResponseIntersectionMember1DataDataDetails accountListResponseIntersectionMember1DataDataDetails
    )
        : base(accountListResponseIntersectionMember1DataDataDetails) { }
#pragma warning restore CS8618

    public AccountListResponseIntersectionMember1DataDataDetails(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountListResponseIntersectionMember1DataDataDetails(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountListResponseIntersectionMember1DataDataDetailsFromRaw.FromRawUnchecked"/>
    public static AccountListResponseIntersectionMember1DataDataDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountListResponseIntersectionMember1DataDataDetailsFromRaw
    : IFromRawJson<AccountListResponseIntersectionMember1DataDataDetails>
{
    /// <inheritdoc/>
    public AccountListResponseIntersectionMember1DataDataDetails FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountListResponseIntersectionMember1DataDataDetails.FromRawUnchecked(rawData);
}

/// <summary>
/// Account status
/// </summary>
[JsonConverter(typeof(AccountListResponseIntersectionMember1DataDataStatusConverter))]
public enum AccountListResponseIntersectionMember1DataDataStatus
{
    Active,
    Inactive,
    Suspended,
}

sealed class AccountListResponseIntersectionMember1DataDataStatusConverter
    : JsonConverter<AccountListResponseIntersectionMember1DataDataStatus>
{
    public override AccountListResponseIntersectionMember1DataDataStatus Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "active" => AccountListResponseIntersectionMember1DataDataStatus.Active,
            "inactive" => AccountListResponseIntersectionMember1DataDataStatus.Inactive,
            "suspended" => AccountListResponseIntersectionMember1DataDataStatus.Suspended,
            _ => (AccountListResponseIntersectionMember1DataDataStatus)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountListResponseIntersectionMember1DataDataStatus value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountListResponseIntersectionMember1DataDataStatus.Active => "active",
                AccountListResponseIntersectionMember1DataDataStatus.Inactive => "inactive",
                AccountListResponseIntersectionMember1DataDataStatus.Suspended => "suspended",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}

/// <summary>
/// Account type
/// </summary>
[JsonConverter(typeof(AccountListResponseIntersectionMember1DataDataTypeConverter))]
public enum AccountListResponseIntersectionMember1DataDataType
{
    Main,
    Sub,
    Virtual,
}

sealed class AccountListResponseIntersectionMember1DataDataTypeConverter
    : JsonConverter<AccountListResponseIntersectionMember1DataDataType>
{
    public override AccountListResponseIntersectionMember1DataDataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "main" => AccountListResponseIntersectionMember1DataDataType.Main,
            "sub" => AccountListResponseIntersectionMember1DataDataType.Sub,
            "virtual" => AccountListResponseIntersectionMember1DataDataType.Virtual,
            _ => (AccountListResponseIntersectionMember1DataDataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        AccountListResponseIntersectionMember1DataDataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                AccountListResponseIntersectionMember1DataDataType.Main => "main",
                AccountListResponseIntersectionMember1DataDataType.Sub => "sub",
                AccountListResponseIntersectionMember1DataDataType.Virtual => "virtual",
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
