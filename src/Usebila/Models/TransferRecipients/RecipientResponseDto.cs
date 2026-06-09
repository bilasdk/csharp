using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;
using Usebila.Exceptions;
using System = System;

namespace Usebila.Models.TransferRecipients;

[JsonConverter(typeof(JsonModelConverter<RecipientResponseDto, RecipientResponseDtoFromRaw>))]
public sealed record class RecipientResponseDto : JsonModel
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
    /// Transfer recipient type
    /// </summary>
    public required ApiEnum<string, RecipientResponseDtoType> Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<ApiEnum<string, RecipientResponseDtoType>>("type");
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

    public RecipientResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public RecipientResponseDto(RecipientResponseDto recipientResponseDto)
        : base(recipientResponseDto) { }
#pragma warning restore CS8618

    public RecipientResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    RecipientResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="RecipientResponseDtoFromRaw.FromRawUnchecked"/>
    public static RecipientResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class RecipientResponseDtoFromRaw : IFromRawJson<RecipientResponseDto>
{
    /// <inheritdoc/>
    public RecipientResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => RecipientResponseDto.FromRawUnchecked(rawData);
}

/// <summary>
/// Transfer recipient type
/// </summary>
[JsonConverter(typeof(RecipientResponseDtoTypeConverter))]
public enum RecipientResponseDtoType
{
    BankAccount,
    MobileMoney,
}

sealed class RecipientResponseDtoTypeConverter : JsonConverter<RecipientResponseDtoType>
{
    public override RecipientResponseDtoType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" => RecipientResponseDtoType.BankAccount,
            "mobile-money" => RecipientResponseDtoType.MobileMoney,
            _ => (RecipientResponseDtoType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        RecipientResponseDtoType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                RecipientResponseDtoType.BankAccount => "bank-account",
                RecipientResponseDtoType.MobileMoney => "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
