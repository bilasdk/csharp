using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using Usebila.Core;

namespace Usebila.Models.Webhooks;

/// <summary>
/// Get delivery history
///
/// <para>NOTE: Do not inherit from this type outside the SDK unless you're okay with
/// breaking changes in non-major versions. We may add new methods in the future that
/// cause existing derived classes to break.</para>
/// </summary>
public record class WebhookGetDeliveriesParams : ParamsBase
{
    public string? ID { get; init; }

    /// <summary>
    /// ISO 8601 end of createdAt range (inclusive)
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
    /// Filter by event type
    /// </summary>
    public string? EventType
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("eventType");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("eventType", value);
        }
    }

    /// <summary>
    /// Page number
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
    /// Items per page
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
    /// ISO 8601 start of createdAt range (inclusive)
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
    /// Filter by status (QUEUED, DELIVERED, FAILED, RETRYING)
    /// </summary>
    public string? Status
    {
        get
        {
            this._rawQueryData.Freeze();
            return this._rawQueryData.GetNullableClass<string>("status");
        }
        init
        {
            if (value == null)
            {
                return;
            }

            this._rawQueryData.Set("status", value);
        }
    }

    public WebhookGetDeliveriesParams() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public WebhookGetDeliveriesParams(WebhookGetDeliveriesParams webhookGetDeliveriesParams)
        : base(webhookGetDeliveriesParams)
    {
        this.ID = webhookGetDeliveriesParams.ID;
    }
#pragma warning restore CS8618

    public WebhookGetDeliveriesParams(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    WebhookGetDeliveriesParams(
        FrozenDictionary<string, JsonElement> rawHeaderData,
        FrozenDictionary<string, JsonElement> rawQueryData,
        string id
    )
    {
        this._rawHeaderData = new(rawHeaderData);
        this._rawQueryData = new(rawQueryData);
        this.ID = id;
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="IFromRawJson{T}.FromRawUnchecked"/>
    public static WebhookGetDeliveriesParams FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawHeaderData,
        IReadOnlyDictionary<string, JsonElement> rawQueryData,
        string id
    )
    {
        return new(
            FrozenDictionary.ToFrozenDictionary(rawHeaderData),
            FrozenDictionary.ToFrozenDictionary(rawQueryData),
            id
        );
    }

    public override string ToString() =>
        JsonSerializer.Serialize(
            FriendlyJsonPrinter.PrintValue(
                new Dictionary<string, JsonElement>()
                {
                    ["ID"] = JsonSerializer.SerializeToElement(this.ID),
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

    public virtual bool Equals(WebhookGetDeliveriesParams? other)
    {
        if (other == null)
        {
            return false;
        }
        return (this.ID?.Equals(other.ID) ?? other.ID == null)
            && this._rawHeaderData.Equals(other._rawHeaderData)
            && this._rawQueryData.Equals(other._rawQueryData);
    }

    public override Uri Url(ClientOptions options)
    {
        return new UriBuilder(
            options.BaseUrl.ToString().TrimEnd('/')
                + string.Format("/api/v1/bila/webhooks/{0}/deliveries", this.ID)
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
