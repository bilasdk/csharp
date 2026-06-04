using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Accounts;

[JsonConverter(
    typeof(JsonModelConverter<AccountGetBalanceResponse, AccountGetBalanceResponseFromRaw>)
)]
public sealed record class AccountGetBalanceResponse : JsonModel
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

    public AccountGetBalanceResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountGetBalanceResponseIntersectionMember1Data>(
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
        AccountGetBalanceResponse accountGetBalanceResponse
    ) =>
        new()
        {
            Message = accountGetBalanceResponse.Message,
            Status = accountGetBalanceResponse.Status,
        };

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Message;
        _ = this.Status;
        this.Data?.Validate();
    }

    public AccountGetBalanceResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountGetBalanceResponse(AccountGetBalanceResponse accountGetBalanceResponse)
        : base(accountGetBalanceResponse) { }
#pragma warning restore CS8618

    public AccountGetBalanceResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountGetBalanceResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountGetBalanceResponseFromRaw.FromRawUnchecked"/>
    public static AccountGetBalanceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountGetBalanceResponseFromRaw : IFromRawJson<AccountGetBalanceResponse>
{
    /// <inheritdoc/>
    public AccountGetBalanceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountGetBalanceResponse.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountGetBalanceResponseIntersectionMember1,
        AccountGetBalanceResponseIntersectionMember1FromRaw
    >)
)]
public sealed record class AccountGetBalanceResponseIntersectionMember1 : JsonModel
{
    public AccountGetBalanceResponseIntersectionMember1Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountGetBalanceResponseIntersectionMember1Data>(
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

    public AccountGetBalanceResponseIntersectionMember1() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountGetBalanceResponseIntersectionMember1(
        AccountGetBalanceResponseIntersectionMember1 accountGetBalanceResponseIntersectionMember1
    )
        : base(accountGetBalanceResponseIntersectionMember1) { }
#pragma warning restore CS8618

    public AccountGetBalanceResponseIntersectionMember1(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountGetBalanceResponseIntersectionMember1(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountGetBalanceResponseIntersectionMember1FromRaw.FromRawUnchecked"/>
    public static AccountGetBalanceResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountGetBalanceResponseIntersectionMember1FromRaw
    : IFromRawJson<AccountGetBalanceResponseIntersectionMember1>
{
    /// <inheritdoc/>
    public AccountGetBalanceResponseIntersectionMember1 FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountGetBalanceResponseIntersectionMember1.FromRawUnchecked(rawData);
}

[JsonConverter(
    typeof(JsonModelConverter<
        AccountGetBalanceResponseIntersectionMember1Data,
        AccountGetBalanceResponseIntersectionMember1DataFromRaw
    >)
)]
public sealed record class AccountGetBalanceResponseIntersectionMember1Data : JsonModel
{
    /// <summary>
    /// Available balance
    /// </summary>
    public required string AvailableBalance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("availableBalance");
        }
        init { this._rawData.Set("availableBalance", value); }
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
    /// Ledger balance
    /// </summary>
    public required string LedgerBalance
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("ledgerBalance");
        }
        init { this._rawData.Set("ledgerBalance", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.AvailableBalance;
        _ = this.Currency;
        _ = this.LedgerBalance;
    }

    public AccountGetBalanceResponseIntersectionMember1Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountGetBalanceResponseIntersectionMember1Data(
        AccountGetBalanceResponseIntersectionMember1Data accountGetBalanceResponseIntersectionMember1Data
    )
        : base(accountGetBalanceResponseIntersectionMember1Data) { }
#pragma warning restore CS8618

    public AccountGetBalanceResponseIntersectionMember1Data(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountGetBalanceResponseIntersectionMember1Data(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountGetBalanceResponseIntersectionMember1DataFromRaw.FromRawUnchecked"/>
    public static AccountGetBalanceResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountGetBalanceResponseIntersectionMember1DataFromRaw
    : IFromRawJson<AccountGetBalanceResponseIntersectionMember1Data>
{
    /// <inheritdoc/>
    public AccountGetBalanceResponseIntersectionMember1Data FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountGetBalanceResponseIntersectionMember1Data.FromRawUnchecked(rawData);
}
