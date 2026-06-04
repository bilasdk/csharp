using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Accounts;
using System = System;

namespace Bila.Models.TransferRecipients;

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientCreateBankAccountResponse,
        TransferRecipientCreateBankAccountResponseFromRaw
    >)
)]
public sealed record class TransferRecipientCreateBankAccountResponse : JsonModel
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

    public TransferRecipientCreateBankAccountResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferRecipientCreateBankAccountResponseIntersectionMember1Data>(
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
        TransferRecipientCreateBankAccountResponse transferRecipientCreateBankAccountResponse
    ) =>
        new()
        {
            Message = transferRecipientCreateBankAccountResponse.Message,
            Status = transferRecipientCreateBankAccountResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransferRecipientCreateBankAccountResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateBankAccountResponse(
        TransferRecipientCreateBankAccountResponse transferRecipientCreateBankAccountResponse
    )
        : base(transferRecipientCreateBankAccountResponse) { }
#pragma warning restore CS8618

    public TransferRecipientCreateBankAccountResponse(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateBankAccountResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateBankAccountResponseFromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateBankAccountResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateBankAccountResponseFromRaw
    : IFromRawJson<TransferRecipientCreateBankAccountResponse>
{
    /// <inheritdoc/>
    public TransferRecipientCreateBankAccountResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientCreateBankAccountResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientCreateBankAccountResponseIntersectionMember1,
        TransferRecipientCreateBankAccountResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferRecipientCreateBankAccountResponseIntersectionMember1 : JsonModel
{
    public TransferRecipientCreateBankAccountResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferRecipientCreateBankAccountResponseIntersectionMember1Data>(
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

    public TransferRecipientCreateBankAccountResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateBankAccountResponseIntersectionMember1(
        TransferRecipientCreateBankAccountResponseIntersectionMember1 transferRecipientCreateBankAccountResponseIntersectionMember1
    )
        : base(transferRecipientCreateBankAccountResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferRecipientCreateBankAccountResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateBankAccountResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateBankAccountResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateBankAccountResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateBankAccountResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferRecipientCreateBankAccountResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferRecipientCreateBankAccountResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientCreateBankAccountResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientCreateBankAccountResponseIntersectionMember1Data,
        TransferRecipientCreateBankAccountResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferRecipientCreateBankAccountResponseIntersectionMember1Data
    : JsonModel
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
        TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
    > Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<
                    string,
                    TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
                >
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

    public TransferRecipientCreateBankAccountResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateBankAccountResponseIntersectionMember1Data(
        TransferRecipientCreateBankAccountResponseIntersectionMember1Data transferRecipientCreateBankAccountResponseIntersectionMember1Data
    )
        : base(transferRecipientCreateBankAccountResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferRecipientCreateBankAccountResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateBankAccountResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateBankAccountResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateBankAccountResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateBankAccountResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferRecipientCreateBankAccountResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferRecipientCreateBankAccountResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        TransferRecipientCreateBankAccountResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Recipient type
/// </summary>
[JsonConverter(
    typeof(TransferRecipientCreateBankAccountResponseIntersectionMember1DataTypeConverter)
)]
public enum TransferRecipientCreateBankAccountResponseIntersectionMember1DataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferRecipientCreateBankAccountResponseIntersectionMember1DataTypeConverter
    : JsonConverter<TransferRecipientCreateBankAccountResponseIntersectionMember1DataType>
{
    public override TransferRecipientCreateBankAccountResponseIntersectionMember1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" =>
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount,
            "mobile-money" =>
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.MobileMoney,
            _ => (TransferRecipientCreateBankAccountResponseIntersectionMember1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferRecipientCreateBankAccountResponseIntersectionMember1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.BankAccount =>
                    "bank-account",
                TransferRecipientCreateBankAccountResponseIntersectionMember1DataType.MobileMoney =>
                    "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
