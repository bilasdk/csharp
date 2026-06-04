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
        TransferRecipientCreateMobileMoneyResponse,
        TransferRecipientCreateMobileMoneyResponseFromRaw
    >)
)]
public sealed record class TransferRecipientCreateMobileMoneyResponse : JsonModel
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

    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data>(
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
        TransferRecipientCreateMobileMoneyResponse transferRecipientCreateMobileMoneyResponse
    ) =>
        new()
        {
            Message = transferRecipientCreateMobileMoneyResponse.Message,
            Status = transferRecipientCreateMobileMoneyResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public TransferRecipientCreateMobileMoneyResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateMobileMoneyResponse(
        TransferRecipientCreateMobileMoneyResponse transferRecipientCreateMobileMoneyResponse
    )
        : base(transferRecipientCreateMobileMoneyResponse) { }
#pragma warning restore CS8618

    public TransferRecipientCreateMobileMoneyResponse(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateMobileMoneyResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateMobileMoneyResponseFromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateMobileMoneyResponseFromRaw
    : IFromRawJson<TransferRecipientCreateMobileMoneyResponse>
{
    /// <inheritdoc/>
    public TransferRecipientCreateMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientCreateMobileMoneyResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1,
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class TransferRecipientCreateMobileMoneyResponseIntersectionMember1 : JsonModel
{
    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data>(
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

    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1(
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1 transferRecipientCreateMobileMoneyResponseIntersectionMember1
    )
        : base(transferRecipientCreateMobileMoneyResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateMobileMoneyResponseIntersectionMember1(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateMobileMoneyResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateMobileMoneyResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateMobileMoneyResponseIntersectionMember1FromRaw
    : IFromRawJson<TransferRecipientCreateMobileMoneyResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientCreateMobileMoneyResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data,
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data
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
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType
    > Type
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<
                ApiEnum<
                    string,
                    TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType
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

    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data(
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data transferRecipientCreateMobileMoneyResponseIntersectionMember1Data
    )
        : base(transferRecipientCreateMobileMoneyResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data(
        FrozenDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataFromRaw
    : IFromRawJson<TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) =>
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}

/// <summary>
/// Recipient type
/// </summary>
[JsonConverter(
    typeof(TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataTypeConverter)
)]
public enum TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType
{
    BankAccount,
    MobileMoney,
}

sealed class TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataTypeConverter
    : JsonConverter<TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType>
{
    public override TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "bank-account" =>
                TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType.BankAccount,
            "mobile-money" =>
                TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType.MobileMoney,
            _ => (TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType.BankAccount =>
                    "bank-account",
                TransferRecipientCreateMobileMoneyResponseIntersectionMember1DataType.MobileMoney =>
                    "mobile-money",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
