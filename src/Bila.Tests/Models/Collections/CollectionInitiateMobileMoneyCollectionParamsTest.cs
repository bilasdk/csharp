using System;
using System.Text.Json;
using Bila.Core;
using Bila.Exceptions;
using Bila.Models.Collections;

namespace Bila.Tests.Models.Collections;

public class CollectionInitiateMobileMoneyCollectionParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new CollectionInitiateMobileMoneyCollectionParams
        {
            Amount = 100.5,
            Country = Country.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "collection-001",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Bearer = Bearer.Customer,
            CustomerName = "John Doe",
            Narration = "Payment for subscription",
        };

        double expectedAmount = 100.5;
        ApiEnum<string, Country> expectedCountry = Country.Zm;
        ApiEnum<string, Operator> expectedOperator = Operator.Airtel;
        string expectedPhone = "0977433571";
        string expectedReference = "collection-001";
        string expectedWalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4";
        ApiEnum<string, Bearer> expectedBearer = Bearer.Customer;
        string expectedCustomerName = "John Doe";
        string expectedNarration = "Payment for subscription";

        Assert.Equal(expectedAmount, parameters.Amount);
        Assert.Equal(expectedCountry, parameters.Country);
        Assert.Equal(expectedOperator, parameters.Operator);
        Assert.Equal(expectedPhone, parameters.Phone);
        Assert.Equal(expectedReference, parameters.Reference);
        Assert.Equal(expectedWalletID, parameters.WalletID);
        Assert.Equal(expectedBearer, parameters.Bearer);
        Assert.Equal(expectedCustomerName, parameters.CustomerName);
        Assert.Equal(expectedNarration, parameters.Narration);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new CollectionInitiateMobileMoneyCollectionParams
        {
            Amount = 100.5,
            Country = Country.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "collection-001",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        Assert.Null(parameters.Bearer);
        Assert.False(parameters.RawBodyData.ContainsKey("bearer"));
        Assert.Null(parameters.CustomerName);
        Assert.False(parameters.RawBodyData.ContainsKey("customerName"));
        Assert.Null(parameters.Narration);
        Assert.False(parameters.RawBodyData.ContainsKey("narration"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new CollectionInitiateMobileMoneyCollectionParams
        {
            Amount = 100.5,
            Country = Country.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "collection-001",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",

            // Null should be interpreted as omitted for these properties
            Bearer = null,
            CustomerName = null,
            Narration = null,
        };

        Assert.Null(parameters.Bearer);
        Assert.False(parameters.RawBodyData.ContainsKey("bearer"));
        Assert.Null(parameters.CustomerName);
        Assert.False(parameters.RawBodyData.ContainsKey("customerName"));
        Assert.Null(parameters.Narration);
        Assert.False(parameters.RawBodyData.ContainsKey("narration"));
    }

    [Fact]
    public void Url_Works()
    {
        CollectionInitiateMobileMoneyCollectionParams parameters = new()
        {
            Amount = 100.5,
            Country = Country.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "collection-001",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/collections/mobile-money"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new CollectionInitiateMobileMoneyCollectionParams
        {
            Amount = 100.5,
            Country = Country.Zm,
            Operator = Operator.Airtel,
            Phone = "0977433571",
            Reference = "collection-001",
            WalletID = "68f11209-451f-4a15-bfcd-d916eb8b09f4",
            Bearer = Bearer.Customer,
            CustomerName = "John Doe",
            Narration = "Payment for subscription",
        };

        CollectionInitiateMobileMoneyCollectionParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class CountryTest : TestBase
{
    [Theory]
    [InlineData(Country.Zm)]
    [InlineData(Country.Ng)]
    public void Validation_Works(Country rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Country> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Country.Zm)]
    [InlineData(Country.Ng)]
    public void SerializationRoundtrip_Works(Country rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Country> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Country>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class OperatorTest : TestBase
{
    [Theory]
    [InlineData(Operator.Airtel)]
    [InlineData(Operator.Mtn)]
    [InlineData(Operator.Zamtel)]
    [InlineData(Operator.Vodacom)]
    public void Validation_Works(Operator rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Operator> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Operator.Airtel)]
    [InlineData(Operator.Mtn)]
    [InlineData(Operator.Zamtel)]
    [InlineData(Operator.Vodacom)]
    public void SerializationRoundtrip_Works(Operator rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Operator> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Operator>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}

public class BearerTest : TestBase
{
    [Theory]
    [InlineData(Bearer.Merchant)]
    [InlineData(Bearer.Customer)]
    public void Validation_Works(Bearer rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Bearer> value = rawValue;
        value.Validate();
    }

    [Fact]
    public void InvalidEnumValidationThrows_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Bearer>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );

        Assert.NotNull(value);
        Assert.Throws<BilaInvalidDataException>(() => value.Validate());
    }

    [Theory]
    [InlineData(Bearer.Merchant)]
    [InlineData(Bearer.Customer)]
    public void SerializationRoundtrip_Works(Bearer rawValue)
    {
        // force implicit conversion because Theory can't do that for us
        ApiEnum<string, Bearer> value = rawValue;

        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Bearer>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }

    [Fact]
    public void InvalidEnumSerializationRoundtrip_Works()
    {
        var value = JsonSerializer.Deserialize<ApiEnum<string, Bearer>>(
            JsonSerializer.SerializeToElement("invalid value"),
            ModelBase.SerializerOptions
        );
        string json = JsonSerializer.Serialize(value, ModelBase.SerializerOptions);
        var deserialized = JsonSerializer.Deserialize<ApiEnum<string, Bearer>>(
            json,
            ModelBase.SerializerOptions
        );

        Assert.Equal(value, deserialized);
    }
}
