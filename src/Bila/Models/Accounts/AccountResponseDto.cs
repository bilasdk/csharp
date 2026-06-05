using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using System = System;

namespace Bila.Models.Accounts;

[JsonConverter(typeof(JsonModelConverter<AccountResponseDto, AccountResponseDtoFromRaw>))]
public sealed record class AccountResponseDto : JsonModel
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
    public required AccountDetailsDto Details
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<AccountDetailsDto>("details");
        }
        init { this._rawData.Set("details", value); }
    }

    /// <summary>
    /// Account status
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
    /// Account type
    /// </summary>
    public required ApiEnum<string, global::Bila.Models.Accounts.Type> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<string, global::Bila.Models.Accounts.Type>
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

    public AccountResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountResponseDto(AccountResponseDto accountResponseDto)
        : base(accountResponseDto) { }
#pragma warning restore CS8618

    public AccountResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountResponseDtoFromRaw.FromRawUnchecked"/>
    public static AccountResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountResponseDtoFromRaw : IFromRawJson<AccountResponseDto>
{
    /// <inheritdoc/>
    public AccountResponseDto FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountResponseDto.FromRawUnchecked(rawData);
}

/// <summary>
/// Account status
/// </summary>
[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Active,
    Inactive,
    Suspended,
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
            "active" => Status.Active,
            "inactive" => Status.Inactive,
            "suspended" => Status.Suspended,
            _ => (Status)(-1),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                Status.Active => "active",
                Status.Inactive => "inactive",
                Status.Suspended => "suspended",
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
[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Main,
    Sub,
    Virtual,
}

sealed class TypeConverter : JsonConverter<global::Bila.Models.Accounts.Type>
{
    public override global::Bila.Models.Accounts.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "main" => global::Bila.Models.Accounts.Type.Main,
            "sub" => global::Bila.Models.Accounts.Type.Sub,
            "virtual" => global::Bila.Models.Accounts.Type.Virtual,
            _ => (global::Bila.Models.Accounts.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Bila.Models.Accounts.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Bila.Models.Accounts.Type.Main => "main",
                global::Bila.Models.Accounts.Type.Sub => "sub",
                global::Bila.Models.Accounts.Type.Virtual => "virtual",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
