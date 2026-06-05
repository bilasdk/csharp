using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Resolve;

[JsonConverter(
    typeof(JsonModelConverter<ResolvedAccountResponseDto, ResolvedAccountResponseDtoFromRaw>)
)]
public sealed record class ResolvedAccountResponseDto : JsonModel
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

    public ResolvedAccountResponseDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public ResolvedAccountResponseDto(ResolvedAccountResponseDto resolvedAccountResponseDto)
        : base(resolvedAccountResponseDto) { }
#pragma warning restore CS8618

    public ResolvedAccountResponseDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    ResolvedAccountResponseDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="ResolvedAccountResponseDtoFromRaw.FromRawUnchecked"/>
    public static ResolvedAccountResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class ResolvedAccountResponseDtoFromRaw : IFromRawJson<ResolvedAccountResponseDto>
{
    /// <inheritdoc/>
    public ResolvedAccountResponseDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => ResolvedAccountResponseDto.FromRawUnchecked(rawData);
}
