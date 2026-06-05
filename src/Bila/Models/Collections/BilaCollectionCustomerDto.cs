using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bila.Core;

namespace Bila.Models.Collections;

[JsonConverter(
    typeof(JsonModelConverter<BilaCollectionCustomerDto, BilaCollectionCustomerDtoFromRaw>)
)]
public sealed record class BilaCollectionCustomerDto : JsonModel
{
    /// <summary>
    /// Customer name
    /// </summary>
    public required string Name
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("name");
        }
        init { this._rawData.Set("name", value); }
    }

    /// <summary>
    /// Mobile money operator
    /// </summary>
    public required string Operator
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("operator");
        }
        init { this._rawData.Set("operator", value); }
    }

    /// <summary>
    /// Customer phone number
    /// </summary>
    public required string Phone
    {
        get
        {
            this._rawData.Freeze();
            return this._rawData.GetNotNullClass<string>("phone");
        }
        init { this._rawData.Set("phone", value); }
    }

    /// <inheritdoc/>
    public override void Validate()
    {
        _ = this.Name;
        _ = this.Operator;
        _ = this.Phone;
    }

    public BilaCollectionCustomerDto() { }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    public BilaCollectionCustomerDto(BilaCollectionCustomerDto bilaCollectionCustomerDto)
        : base(bilaCollectionCustomerDto) { }
#pragma warning restore CS8618

    public BilaCollectionCustomerDto(IReadOnlyDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }

#pragma warning disable CS8618
    [SetsRequiredMembers]
    BilaCollectionCustomerDto(FrozenDictionary<string, JsonElement> rawData)
    {
        this._rawData = new(rawData);
    }
#pragma warning restore CS8618

    /// <inheritdoc cref="BilaCollectionCustomerDtoFromRaw.FromRawUnchecked"/>
    public static BilaCollectionCustomerDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    )
    {
        return new(FrozenDictionary.ToFrozenDictionary(rawData));
    }
}

class BilaCollectionCustomerDtoFromRaw : IFromRawJson<BilaCollectionCustomerDto>
{
    /// <inheritdoc/>
    public BilaCollectionCustomerDto FromRawUnchecked(
        IReadOnlyDictionary<string, JsonElement> rawData
    ) => BilaCollectionCustomerDto.FromRawUnchecked(rawData);
}
