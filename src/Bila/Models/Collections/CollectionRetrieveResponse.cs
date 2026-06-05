using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Collections;

[JsonConverter(
    typeof(JsonModelConverter<CollectionRetrieveResponse, CollectionRetrieveResponseFromRaw>)
)]
public sealed record class CollectionRetrieveResponse : JsonModel
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

    public BilaCollectionResponseDto? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<BilaCollectionResponseDto>("data");
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

    public CollectionRetrieveResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionRetrieveResponse(CollectionRetrieveResponse collectionRetrieveResponse)
        : base(collectionRetrieveResponse) { }
#pragma warning restore CS8618

    public CollectionRetrieveResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionRetrieveResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionRetrieveResponseFromRaw.FromRawUnchecked"/>
    public static CollectionRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionRetrieveResponseFromRaw : IFromRawJson<CollectionRetrieveResponse>
{
    /// <inheritdoc/>
    public CollectionRetrieveResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionRetrieveResponse.FromRawUnchecked(rawData);
}
