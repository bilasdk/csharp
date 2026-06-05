using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models.TransferRecipients;

[JsonConverter(
    typeof(JsonModelConverter<TransferRecipientListResponse, TransferRecipientListResponseFromRaw>)
)]
public sealed record class TransferRecipientListResponse : JsonModel
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

    public Data? Data
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNullableClass<Data>("data");
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

    public TransferRecipientListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransferRecipientListResponse(
        TransferRecipientListResponse transferRecipientListResponse
    )
        : base(transferRecipientListResponse) { }
#pragma warning restore CS8618

    public TransferRecipientListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransferRecipientListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransferRecipientListResponseFromRaw.FromRawUnchecked"/>
    public static TransferRecipientListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransferRecipientListResponseFromRaw : IFromRawJson<TransferRecipientListResponse>
{
    /// <inheritdoc/>
    public TransferRecipientListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransferRecipientListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// List of recipients
    /// </summary>
    public required IReadOnlyList<RecipientResponseDto> DataValue
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<RecipientResponseDto>>("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<RecipientResponseDto>>(
                "data",
                ImmutableArray.ToImmutableArray(value)
            );
        }
    }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    public required PaginationMetaDto Meta
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<PaginationMetaDto>("meta");
        }
        init { this._rawData.Set("meta", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        foreach (var item in this.DataValue)
        {
            item.Validate();
        }
        this.Meta.Validate();
    }

    public Data() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public Data(Data data)
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

    /// <inheritdoc cref="DataFromRaw.FromRawUnchecked"/>
    public static Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class DataFromRaw : IFromRawJson<Data>
{
    /// <inheritdoc/>
    public Data FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        Data.FromRawUnchecked(rawData);
}
