using System;
using System.Text.Json;
using Usebila.Core;
using Usebila.Exceptions;
using Usebila.Models.Resolve;

namespace Usebila.Tests.Models.Resolve;

public class ResolveBankAccountParamsTest : TestBase
{
    [Fact]
    public void FieldRoundtrip_Works()
    {
        var parameters = new ResolveBankAccountParams
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",
            Country = Country.Zm,
        };

        string expectedAccountNumber = "1234567890";
        string expectedBankID = "bank-001";
        ApiEnum<string, Country> expectedCountry = Country.Zm;

        Assert.Equal(expectedAccountNumber, parameters.AccountNumber);
        Assert.Equal(expectedBankID, parameters.BankID);
        Assert.Equal(expectedCountry, parameters.Country);
    }

    [Fact]
    public void OptionalNonNullableParamsUnsetAreNotSet_Works()
    {
        var parameters = new ResolveBankAccountParams
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",
        };

        Assert.Null(parameters.Country);
        Assert.False(parameters.RawBodyData.ContainsKey("country"));
    }

    [Fact]
    public void OptionalNonNullableParamsSetToNullAreNotSet_Works()
    {
        var parameters = new ResolveBankAccountParams
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",

            // Null should be interpreted as omitted for these properties
            Country = null,
        };

        Assert.Null(parameters.Country);
        Assert.False(parameters.RawBodyData.ContainsKey("country"));
    }

    [Fact]
    public void Url_Works()
    {
        ResolveBankAccountParams parameters = new()
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",
        };

        var url = parameters.Url(new() { ApiKey = "My API Key" });

        Assert.True(
            TestBase.UrisEqual(
                new Uri("https://api.usebila.com/api/v1/bila/resolve/bank-account"),
                url
            )
        );
    }

    [Fact]
    public void CopyConstructor_Works()
    {
        var parameters = new ResolveBankAccountParams
        {
            AccountNumber = "1234567890",
            BankID = "bank-001",
            Country = Country.Zm,
        };

        ResolveBankAccountParams copied = new(parameters);

        Assert.Equal(parameters, copied);
    }
}

public class CountryTest : TestBase
{
    [Theory]
    [InlineData(Country.Zm)]
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
