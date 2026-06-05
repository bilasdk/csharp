using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Accounts;

[JsonConverter(typeof(JsonModelConverter<AccountDetailsDto, AccountDetailsDtoFromRaw>))]
public sealed record class AccountDetailsDto : JsonModel
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

    public AccountDetailsDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public AccountDetailsDto(AccountDetailsDto accountDetailsDto)
        : base(accountDetailsDto) { }
#pragma warning restore CS8618

    public AccountDetailsDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    AccountDetailsDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="AccountDetailsDtoFromRaw.FromRawUnchecked"/>
    public static AccountDetailsDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class AccountDetailsDtoFromRaw : IFromRawJson<AccountDetailsDto>
{
    /// <inheritdoc/>
    public AccountDetailsDto FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        AccountDetailsDto.FromRawUnchecked(rawData);
}
