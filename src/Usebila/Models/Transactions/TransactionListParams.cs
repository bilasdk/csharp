using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;
using Usebila.Exceptions;
using System = System;

namespace Usebila.Models.Transactions;

/// <summary>
/// Retrieve a paginated list of transactions
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class TransactionListParams : ParamsBase
{
    /// <summary>
    /// Filter by account ID
    /// </summary>
    public string? AccountID
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("accountId");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("accountId", value);
        }
    }

    /// <summary>
    /// Filter by end date (ISO 8601)
    /// </summary>
    public string? EndDate
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("endDate");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("endDate", value);
        }
    }

    /// <summary>
    /// Page number (default: 1)
    /// </summary>
    public double? Page
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<double>("page");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("page", value);
        }
    }

    /// <summary>
    /// Items per page (default: 50)
    /// </summary>
    public double? PerPage
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableStruct<double>("perPage");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("perPage", value);
        }
    }

    /// <summary>
    /// Filter by start date (ISO 8601)
    /// </summary>
    public string? StartDate
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("startDate");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("startDate", value);
        }
    }

    /// <summary>
    /// Filter by transaction type
    /// </summary>
    public ApiEnum<string, global::Usebila.Models.Transactions.Type>? Type
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<
                ApiEnum<string, global::Usebila.Models.Transactions.Type>
            >("type");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("type", value);
        }
    }

    public TransactionListParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionListParams(TransactionListParams transactionListParams)
        : base(transactionListParams) { }
#pragma warning restore CS8618

    public TransactionListParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionListParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson{T}.FromRawUnchecked"/>
    public static TransactionListParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData)
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(
                new Dictionary<string, JsonElement>()
                {
                    ["HeaderData"] = FriendlyJsonPrinter.PrintValue(
                        JsonSerializer.SerializeToElement(this._rawHeaderData.Freeze())
                    ),
                    ["QueryData"] = FriendlyJsonPrinter.PrintValue(
                        JsonSerializer.SerializeToElement(this._rawQueryData.Freeze())
                    ),
                }
            ),
            ModelBase.ToStringSerializerOptions
        );

    public virtual bool Equals(TransactionListParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData);
    }

    public override System::Uri Url(ClientOptions options)
    {
        return new System::UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/') + "/api/v1/bila/transactions"
        )
        {
            Query = this.QueryString(options),
        }.Uri;
    }

    internal override void AddHeadersToRequest(HttpRequestMessage request, ClientOptions options)
    {
        ParamsBase.AddDefaultHeaders(request, options);
        foreach (var item in this.RawHeaderData)
        {
            ParamsBase.AddHeaderElementToRequest(request, item.Key, item.Value);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }
}

/// <summary>
/// Filter by transaction type
/// </summary>
[JsonConverter(typeof(TypeConverter))]
public enum Type
{
    Credit,
    Debit,
}

sealed class TypeConverter : JsonConverter<global::Usebila.Models.Transactions.Type>
{
    public override global::Usebila.Models.Transactions.Type Read(
        ref Utf8JsonReader reader,
        System::Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonSerializer.Deserialize<string>(ref reader, options) switch
        {
            "credit" => global::Usebila.Models.Transactions.Type.Credit,
            "debit" => global::Usebila.Models.Transactions.Type.Debit,
            _ => (global::Usebila.Models.Transactions.Type)(-1),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        global::Usebila.Models.Transactions.Type value,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(
            writer,
            value switch
            {
                global::Usebila.Models.Transactions.Type.Credit => "credit",
                global::Usebila.Models.Transactions.Type.Debit => "debit",
                _ => throw new BilaInvalidDataException(
                    string.Format("Invalid value '{0}' in {1}", value, nameof(value))
                ),
            },
            options
        );
    }
}
