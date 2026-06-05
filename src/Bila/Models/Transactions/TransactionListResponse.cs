using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Transactions;

[JsonConverter(typeof(JsonModelConverter<TransactionListResponse, TransactionListResponseFromRaw>))]
public sealed record class TransactionListResponse : JsonModel
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

    public TransactionListResponse() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public TransactionListResponse(TransactionListResponse transactionListResponse)
        : base(transactionListResponse) { }
#pragma warning restore CS8618

    public TransactionListResponse(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    TransactionListResponse(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="TransactionListResponseFromRaw.FromRawUnchecked"/>
    public static TransactionListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class TransactionListResponseFromRaw : IFromRawJson<TransactionListResponse>
{
    /// <inheritdoc/>
    public TransactionListResponse FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => TransactionListResponse.FromRawUnchecked(rawData);
}

[JsonConverter(typeof(JsonModelConverter<Data, DataFromRaw>))]
public sealed record class Data : JsonModel
{
    /// <summary>
    /// List of transactions
    /// </summary>
    public required IReadOnlyList<TransactionResponseDto> DataValue
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<ImmutableArray<TransactionResponseDto>>("data");
        }
        init
        {
            this._rawData.Set<ImmutableArray<TransactionResponseDto>>(
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
