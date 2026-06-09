using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Usebila.Core;

namespace Usebila.Models;

[JsonConverter(typeof(JsonModelConverter<PaginationMetaDto, PaginationMetaDtoFromRaw>))]
public sealed record class PaginationMetaDto : JsonModel
{
    /// <summary>
    /// Current page number
    /// </summary>
    public required double CurrentPage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("currentPage");
        }
        init { this._rawData.Set("currentPage", value); }
    }

    /// <summary>
    /// Total number of pages
    /// </summary>
    public required double PageCount
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("pageCount");
        }
        init { this._rawData.Set("pageCount", value); }
    }

    /// <summary>
    /// Items per page
    /// </summary>
    public required double PerPage
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("perPage");
        }
        init { this._rawData.Set("perPage", value); }
    }

    /// <summary>
    /// Total number of records
    /// </summary>
    public required double Total
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullStruct<double>("total");
        }
        init { this._rawData.Set("total", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.CurrentPage;
        _ = this.PageCount;
        _ = this.PerPage;
        _ = this.Total;
    }

    public PaginationMetaDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public PaginationMetaDto(PaginationMetaDto paginationMetaDto)
        : base(paginationMetaDto) { }
#pragma warning restore CS8618

    public PaginationMetaDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    PaginationMetaDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="PaginationMetaDtoFromRaw.FromRawUnchecked"/>
    public static PaginationMetaDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class PaginationMetaDtoFromRaw : IFromRawJson<PaginationMetaDto>
{
    /// <inheritdoc/>
    public PaginationMetaDto FromRawUnchecked(IReadOnlyDictionary<string, JsonElement> rawData) =>
        PaginationMetaDto.FromRawUnchecked(rawData);
}
