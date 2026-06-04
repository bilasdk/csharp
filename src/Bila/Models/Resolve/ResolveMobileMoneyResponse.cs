using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Models.Resolve;

[JsonConverter(
    typeof(JsonModelConverter<ResolveMobileMoneyResponse, ResolveMobileMoneyResponseFromRaw>)
)]
public sealed record class ResolveMobileMoneyResponse : JsonModel
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

    public ResolveMobileMoneyResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ResolveMobileMoneyResponseIntersectionMember1Data>(
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
        ResolveMobileMoneyResponse resolveMobileMoneyResponse
    ) =>
        new()
        {
            Message = resolveMobileMoneyResponse.Message,
            Status = resolveMobileMoneyResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public ResolveMobileMoneyResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolveMobileMoneyResponse(ResolveMobileMoneyResponse resolveMobileMoneyResponse)
        : base(resolveMobileMoneyResponse) { }
#pragma warning restore CS8618

    public ResolveMobileMoneyResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolveMobileMoneyResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolveMobileMoneyResponseFromRaw.FromRawUnchecked"/>
    public static ResolveMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolveMobileMoneyResponseFromRaw : IFromRawJson<ResolveMobileMoneyResponse>
{
    /// <inheritdoc/>
    public ResolveMobileMoneyResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolveMobileMoneyResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        ResolveMobileMoneyResponseIntersectionMember1,
        ResolveMobileMoneyResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class ResolveMobileMoneyResponseIntersectionMember1 : JsonModel
{
    public ResolveMobileMoneyResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<ResolveMobileMoneyResponseIntersectionMember1Data>(
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

    public ResolveMobileMoneyResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolveMobileMoneyResponseIntersectionMember1(
        ResolveMobileMoneyResponseIntersectionMember1 resolveMobileMoneyResponseIntersectionMember1
    )
        : base(resolveMobileMoneyResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public ResolveMobileMoneyResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolveMobileMoneyResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolveMobileMoneyResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static ResolveMobileMoneyResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolveMobileMoneyResponseIntersectionMember1FromRaw
    : IFromRawJson<ResolveMobileMoneyResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public ResolveMobileMoneyResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolveMobileMoneyResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        ResolveMobileMoneyResponseIntersectionMember1Data,
        ResolveMobileMoneyResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class ResolveMobileMoneyResponseIntersectionMember1Data : JsonModel
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
    /// Bank account number
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
    /// Bank ID
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
    /// Bank name
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
    /// Mobile money operator
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
    /// Phone number
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
        _ = this.AccountName;
        _ = this.Country;
        _ = this.AccountNumber;
        _ = this.BankID;
        _ = this.BankName;
        _ = this.Operator;
        _ = this.Phone;
    }

    public ResolveMobileMoneyResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolveMobileMoneyResponseIntersectionMember1Data(
        ResolveMobileMoneyResponseIntersectionMember1Data resolveMobileMoneyResponseIntersectionMember1Data
    )
        : base(resolveMobileMoneyResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public ResolveMobileMoneyResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolveMobileMoneyResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolveMobileMoneyResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static ResolveMobileMoneyResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolveMobileMoneyResponseIntersectionMember1DataFromRaw
    : IFromRawJson<ResolveMobileMoneyResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public ResolveMobileMoneyResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolveMobileMoneyResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}
