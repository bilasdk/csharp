using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Accounts;

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

    public AccountGetBalanceResponseData? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<AccountGetBalanceResponseData>("data");
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
    typeof(JsonModelConverter<AccountGetBalanceResponseData, AccountGetBalanceResponseDataFromRaw>)
)]
public sealed record class AccountGetBalanceResponseData : JsonModel
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

    public AccountGetBalanceResponseData() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountGetBalanceResponseData(
        AccountGetBalanceResponseData accountGetBalanceResponseData
    )
        : base(accountGetBalanceResponseData) { }
#pragma warning restore CS8618

    public AccountGetBalanceResponseData(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountGetBalanceResponseData(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountGetBalanceResponseDataFromRaw.FromRawUnchecked"/>
    public static AccountGetBalanceResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountGetBalanceResponseDataFromRaw : IFromRawJson<AccountGetBalanceResponseData>
{
    /// <inheritdoc/>
    public AccountGetBalanceResponseData FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => AccountGetBalanceResponseData.FromRawUnchecked(rawData);
}
