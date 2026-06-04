using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;
using Bila.Models.Accounts;

namespace Bila.Models.Resolve;

[JsonConverter(
    typeof(JsonModelConverter<ResolveBankAccountResponse, ResolveBankAccountResponseFromRaw>)
)]
public sealed record class ResolveBankAccountResponse : JsonModel
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

    public global::Bila.Models.Resolve.Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<global::Bila.Models.Resolve.Data>("data");
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
        ResolveBankAccountResponse resolveBankAccountResponse
    ) =>
        new()
        {
            Message = resolveBankAccountResponse.Message,
            Status = resolveBankAccountResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public ResolveBankAccountResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolveBankAccountResponse(ResolveBankAccountResponse resolveBankAccountResponse)
        : base(resolveBankAccountResponse) { }
#pragma warning restore CS8618

    public ResolveBankAccountResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolveBankAccountResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolveBankAccountResponseFromRaw.FromRawUnchecked"/>
    public static ResolveBankAccountResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolveBankAccountResponseFromRaw : IFromRawJson<ResolveBankAccountResponse>
{
    /// <inheritdoc/>
    public ResolveBankAccountResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolveBankAccountResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::Bila.Models.Resolve.IntersectionMember1,
        global::Bila.Models.Resolve.IntersectionMember1FromRaw
    >)
)]
public sealed record class IntersectionMember1 : JsonModel
{
    public global::Bila.Models.Resolve.Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<global::Bila.Models.Resolve.Data>("data");
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

    public IntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public IntersectionMember1(global::Bila.Models.Resolve.IntersectionMember1 intersectionMember1)
        : base(intersectionMember1) { }
#pragma warning restore CS8618

    public IntersectionMember1(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    IntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="global::Bila.Models.Resolve.IntersectionMember1FromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.Resolve.IntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class IntersectionMember1FromRaw : IFromRawJson<global::Bila.Models.Resolve.IntersectionMember1>
{
    /// <inheritdoc/>
    public global::Bila.Models.Resolve.IntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.Resolve.IntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        global::Bila.Models.Resolve.Data,
        global::Bila.Models.Resolve.DataFromRaw
    >)
)]
public sealed record class Data : JsonModel
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

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(global::Bila.Models.Resolve.Data data)
        : base(data) { }
#pragma warning restore CS8618

    public Data(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="global::Bila.Models.Resolve.DataFromRaw.FromRawUnchecked"/>
    public static global::Bila.Models.Resolve.Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<global::Bila.Models.Resolve.Data>
{
    /// <inheritdoc/>
    public global::Bila.Models.Resolve.Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => global::Bila.Models.Resolve.Data.FromRawUnchecked(rawData);
}
