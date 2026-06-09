using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.Collections;

[JsonConverter(
    typeof(JsonModelConverter<
        CollectionGetStatusByReferenceResponse,
        CollectionGetStatusByReferenceResponseFromRaw
    >)
)]
public sealed record class CollectionGetStatusByReferenceResponse : JsonModel
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

    public CollectionGetStatusByReferenceResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public CollectionGetStatusByReferenceResponse(
        CollectionGetStatusByReferenceResponse collectionGetStatusByReferenceResponse
    )
        : base(collectionGetStatusByReferenceResponse) { }
#pragma warning restore CS8618

    public CollectionGetStatusByReferenceResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    CollectionGetStatusByReferenceResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="CollectionGetStatusByReferenceResponseFromRaw.FromRawUnchecked"/>
    public static CollectionGetStatusByReferenceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class CollectionGetStatusByReferenceResponseFromRaw
    : IFromRawJson<CollectionGetStatusByReferenceResponse>
{
    /// <inheritdoc/>
    public CollectionGetStatusByReferenceResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => CollectionGetStatusByReferenceResponse.FromRawUnchecked(rawData);
}
